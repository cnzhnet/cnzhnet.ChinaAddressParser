package com.yscloud.tablet

import com.google.gson.Gson
import com.google.gson.GsonBuilder
import com.yscloud.tablet.data.ChinaAddressParser
import com.yscloud.tablet.data.entities.CRMAddress
import org.junit.Test

class AddressParserUnitTest {
    @Test
    fun test() {
        val parser: ChinaAddressParser = ChinaAddressParser();
        val gson: Gson = GsonBuilder().setPrettyPrinting().create();
        var address: CRMAddress = parser.parse("盘龙区金洲北路246号");
        println(gson.toJson(address));
        address = parser.parse("南山区高新中一道长园新材料港6栋5楼");
        println(gson.toJson(address));
        address = parser.parse("深圳市南山区高新中一道长园新材料港6栋5楼");
        println(gson.toJson(address));
        println("单元测试已运行完毕!");
    }
}