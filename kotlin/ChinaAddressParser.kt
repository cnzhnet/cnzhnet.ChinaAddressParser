package com.yscloud.tablet.data

import com.yscloud.tablet.data.entities.CRMAddress

/** 中华人民共和国地址智能解析器. */
class ChinaAddressParser {
    private val tables: RegionDivisionsTables = RegionDivisionsTables();
    private val provincePattern: Regex = Regex(".+?(省|市|自治区|特别行政区|区)");
    private val cityPattern: Regex = Regex(".+?(省|市|自治州|州|地区|盟|县|自治县|区|林区)");
    private val areaPattern: Regex = Regex(".+?(市|县|自治县|旗|自治旗|区|林区|特区|街道|镇|乡)");

    private fun parse(address: String, info: CRMAddress) {
        val keywords: MutableList<String> = mutableListOf();
        var matches: Sequence<MatchResult> = provincePattern.findAll(address);
        matches.forEach { keywords.add(it.value) };
        matches = cityPattern.findAll(address);
        matches.forEach { keywords.add(it.value) };
        matches = areaPattern.findAll(address);
        matches.forEach { keywords.add(it.value) };
        var results: List<Pair<Int, RegionDivision>>;
        var find: RegionDivision;
        var passArea: Boolean = false;
        var passCity: Boolean = false;
        var index: Int = keywords.indices.last;
        while (index > 0) {
            // 搜索所有区县级.
            if (!passArea) {
                for (i in index downTo 0) {
                    results = tables.areas.filterValues {
                        it.name.contains(keywords[i], true)
                    }.toList();
                    if (results.isEmpty())
                        continue;
                    find = results.first().second;
                    info.area = find.name;
                    tables.findById(info, find.pid, DivisionSearchProperty.City);
                    index = i;
                    break;
                }
                passArea = true;
            }
            // 搜索所有省辖市（区县级名称有可能同名，故此处仍然需要继续修正省辖市）.
            if (!passCity) {
                for (i in index downTo 0) {
                    results = tables.citys.filterValues {
                        it.name.contains(keywords[i], true)
                    }.toList();
                    if (results.isEmpty())
                        continue;
                    find = results.first().second;
                    info.city = find.name;
                    tables.findById(info, find.pid, DivisionSearchProperty.Province);
                    index = i;
                    break;
                }
                passCity = true;
            }
            // 搜索所有省（不同省的辖市名称有可能相同，此处仍然需要继续修正省）.
            for (i in index downTo 0) {
                results = tables.provinces.filterValues {
                    it.name.contains(keywords[i], true)
                }.toList();
                if (results.isEmpty())
                    continue;
                find = results.first().second;
                info.province = find.name;
                break;
            }
            index = -1;
        }
    }

    /** 解释地址.
     * @param address 要解析的地址字符串.
     * @return 返回解析后的地址信息对象. */
    public fun parse(address: String): CRMAddress {
        val info: CRMAddress = CRMAddress();
        if (address.isEmpty())
            return info;
        parse(address, info);
        if (info.province.isEmpty() && info.city.isEmpty() && info.area.isEmpty()) {
            info.street = address;
            return info;
        }
        var index: Int;
        if (info.area.isNotEmpty()) {
            index = address.lastIndexOf(info.area) + info.area.length;
            info.street = address.substring(index);
            return info;
        }
        if (info.city.isNotEmpty()) {
            index = address.lastIndexOf(info.city) + info.city.length;
            info.street = address.substring(index);
            return info;
        }
        if (info.province.isNotEmpty()) {
            index = address.lastIndexOf(info.city) + info.city.length;
            info.street = address.substring(index);
        }
        return info;
    }
}