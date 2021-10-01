package com.yscloud.tablet.data

import com.yscloud.tablet.data.entities.CRMAddress

/** 表示行政区划的数据实体. */
data class RegionDivision(
    var id: Int,
    var pid: Int,
    var name: String,
    var zipCode: Long = 0x0000000000000000
);

/** 行政区划的搜索属性. */
enum class DivisionSearchProperty {
    Province, City, Area
}

/** 表示行政区划字典表. */
class RegionDivisionsTables {
    /** 顶级行政区划（省、直辖市、自治区）. */
    public val provinces: MutableMap<Int, RegionDivision> = mutableMapOf();

    /** 二级行政区划（市区）. */
    public val citys: MutableMap<Int, RegionDivision> = mutableMapOf();

    /** 县、地级市. */
    public val areas: MutableMap<Int, RegionDivision> = mutableMapOf();

    /** 初始化. */
    init {
        initProvinces();
        initCitys();
        initAreas0();
        initAreas1();
        initAreas2();
        initAreas3();
        initAreas4();
        initAreas5();
        initAreas6();
    }

    /** 初始化顶级行政区划. */
    private fun initProvinces() {
        provinces[1] = RegionDivision(1, 0, "北京", 0);
        provinces[2] = RegionDivision(2, 0, "天津", 0);
        provinces[3] = RegionDivision(3, 0, "河北省", 0);
        provinces[4] = RegionDivision(4, 0, "山西省", 0);
        provinces[5] = RegionDivision(5, 0, "内蒙古自治区", 0);
        provinces[6] = RegionDivision(6, 0, "辽宁省", 0);
        provinces[7] = RegionDivision(7, 0, "吉林省", 0);
        provinces[8] = RegionDivision(8, 0, "黑龙江省", 0);
        provinces[9] = RegionDivision(9, 0, "上海", 0);
        provinces[10] = RegionDivision(10, 0, "江苏省", 0);
        provinces[11] = RegionDivision(11, 0, "浙江省", 0);
        provinces[12] = RegionDivision(12, 0, "安徽省", 0);
        provinces[13] = RegionDivision(13, 0, "福建省", 0);
        provinces[14] = RegionDivision(14, 0, "江西省", 0);
        provinces[15] = RegionDivision(15, 0, "山东省", 0);
        provinces[16] = RegionDivision(16, 0, "河南省", 0);
        provinces[17] = RegionDivision(17, 0, "湖北省", 0);
        provinces[18] = RegionDivision(18, 0, "湖南省", 0);
        provinces[19] = RegionDivision(19, 0, "广东省", 0);
        provinces[20] = RegionDivision(20, 0, "广西壮族自治区", 0);
        provinces[21] = RegionDivision(21, 0, "海南省", 0);
        provinces[22] = RegionDivision(22, 0, "重庆", 0);
        provinces[23] = RegionDivision(23, 0, "四川省", 0);
        provinces[24] = RegionDivision(24, 0, "贵州省", 0);
        provinces[25] = RegionDivision(25, 0, "云南省", 0);
        provinces[26] = RegionDivision(26, 0, "西藏自治区", 0);
        provinces[27] = RegionDivision(27, 0, "陕西省", 0);
        provinces[28] = RegionDivision(28, 0, "甘肃省", 0);
        provinces[29] = RegionDivision(29, 0, "青海省", 0);
        provinces[30] = RegionDivision(30, 0, "宁夏回族自治区", 0);
        provinces[31] = RegionDivision(31, 0, "新疆维吾尔自治区", 0);
        provinces[32] = RegionDivision(32, 0, "台湾省", 0);
        provinces[33] = RegionDivision(33, 0, "香港特别行政区", 0);
        provinces[34] = RegionDivision(34, 0, "澳门特别行政区", 0);
        provinces[35] = RegionDivision(35, 0, "海外", 0);
    }

    /** 根据 ID 查找指定的地址属性.
     * @param address 地址信息.
     * @param id 行政区划的 ID.
     * @param prop 要查找的地址属性. */
    public fun findById(address: CRMAddress, id: Int, prop: DivisionSearchProperty): CRMAddress {
        var division: RegionDivision? = null;
        when (prop) {
            DivisionSearchProperty.Province -> {
                division = provinces[id];
                division?.let { address.province = it.name }
            }
            DivisionSearchProperty.City -> {
                division = citys[id];
                division?.let {
                    address.city = it.name;
                    findById(address, it.pid, DivisionSearchProperty.Province);
                }
            }
            DivisionSearchProperty.Area -> {
                division = areas[id];
                division?.let {
                    address.area = it.name;
                    findById(address, it.pid, DivisionSearchProperty.City);
                }
            }
        }
        return address;
    }
}