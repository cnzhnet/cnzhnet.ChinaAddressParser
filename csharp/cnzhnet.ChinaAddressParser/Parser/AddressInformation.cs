using System;
using System.Text;

namespace cnzhnet.ChinaAddressParser
{
    /// <summary>
    /// 表示结构化的地址信息.
    /// </summary>
    [Serializable()]
    public class AddressInformation
    {
        /// <summary>
        /// 省份或地辖市.
        /// </summary>
        public string province { get; set; }

        /// <summary>
        /// 市.
        /// </summary>
        public string city { get; set; }

        /// <summary>
        /// 县或区
        /// </summary>
        public string area { get; set; }

        /// <summary>
        /// 街道或更村等.
        /// </summary>
        public string street { get; set; }

        /// <summary>
        /// 创建一个 <see cref="AddressInformation"/> 的对象实例.
        /// </summary>
        public AddressInformation() { }

        /// <summary>
        /// 判断该地址是否为空.
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty() => string.IsNullOrEmpty(province) &&
                                 string.IsNullOrEmpty(city) &&
                                 string.IsNullOrEmpty(area) &&
                                 string.IsNullOrEmpty(street);
        /// <summary>
        /// 输出为字符串.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            if (!string.IsNullOrEmpty(province))
                builder.Append(province);
            if (!string.IsNullOrEmpty(city))
                builder.Append(city);
            if (string.IsNullOrEmpty(area))
                builder.Append(area);
            if (string.IsNullOrEmpty(street))
                builder.Append(street);
            return builder.ToString();
        }
    }

    /// <summary>
    /// 表示行政区划的数据实体.
    /// </summary>
    [Serializable()]
    public class RegionDivision
    { 
        /// <summary>
        /// 表示区域 ID.
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 上级区域划分的 ID.
        /// </summary>
        public int pid { get; set; }

        /// <summary>
        /// 表示区域划分的名称.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 表示邮编（允许为空.）
        /// </summary>
        public long zipCode { get; set; }

        /// <summary>
        /// 创建一个 <see cref="RegionDivision"/> 的对象实例.
        /// </summary>
        /// <param name="_id">区域 ID.</param>
        /// <param name="_pid">上级区域划分的 ID.</param>
        /// <param name="_name">区域划分的名称.</param>
        /// <param name="_zipcode">邮编（允许为空.）</param>
        public RegionDivision(int _id, int _pid, string _name, long _zipcode = 0)
        {
            id = _id;
            pid = _pid;
            name = _name;
            zipCode = _zipcode;
        }

        /// <summary>
        /// 创建一个空的 <see cref="RegionDivision"/> 对象实例.
        /// </summary>
        public RegionDivision() : this(_id: -1, _pid: -1, _name: null)
        { }
    }

    /// <summary>
    /// 行政区划的搜索属性.
    /// </summary>
    public enum DivisionSearchProperty
    {
        Province,
        City,
        Area
    }
}
