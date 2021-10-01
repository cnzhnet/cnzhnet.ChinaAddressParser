package com.yscloud.tablet.data.entities;

/** 表示地址信息. */
public class CRMAddress {
    private String province;
    private String city;
    private String area;
    private String street;

    public CRMAddress() {}

    /** 获取省级地区信息. */
    public String getProvince() { return province; }
    /** 设置省级地区信息.
     * @param value 要设置的值. */
    public void setProvince(String value) { province = value; }
    /** 获取市级地区信息. */
    public String getCity() { return city; };
    /** 设置市级地区信息.
     * @param value 要设置的值. */
    public void setCity(String value) { city = value; }
    /** 获取区/县信息. */
    public String getArea() { return area; }
    /** 设置区/县信息。
     * @param value 要设置的值. */
    public void setArea(String value) { area = value; }
    /** 获取街道信息. */
    public String getStreet() { return street; }
    /** 设置街道信息.
     * @param value 要设置的值. */
    public void setStreet(String value) { street = value; }

    /** 输出为字符串. */
    @Override
    public String toString()
    {
        StringBuffer buffer = new StringBuffer(province);
        buffer.append(city).append(area).append(street);
        return buffer.toString();
    }
}
