using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnzhnet.ChinaAddressParser
{
    /// <summary>
    /// 表示顶级区域划分字典信息.
    /// </summary>
    public sealed partial class RegionDivisionsTables : IDisposable
    {
        /// <summary>
        /// 顶级行政区划（省、直辖市、自治区）.
        /// </summary>
        public Dictionary<int, RegionDivision> Provinces { get; private set; }

        /// <summary>
        /// 二级行政区划（市区）.
        /// </summary>
        public Dictionary<int, RegionDivision> Citys { get; private set; }

        /// <summary>
        /// 县、地级市
        /// </summary>
        public Dictionary<int, RegionDivision> Areas { get; private set; }

        /// <summary>
        /// 创建一个 <see cref="RegionDivisionsTables"/>
        /// </summary>
        public RegionDivisionsTables()
        {
            Provinces = new Dictionary<int, RegionDivision>();
            Citys = new Dictionary<int, RegionDivision>();
            Areas = new Dictionary<int, RegionDivision>();
            InitProvinces();
            InitCitys();
            InitAreas();
        }

        /// <summary>
        /// 初始化顶级行政区域.
        /// </summary>
        private void InitProvinces()
        {
            Provinces.Add(1, new RegionDivision(1, 0, "北京", 0));
            Provinces.Add(2, new RegionDivision(2, 0, "天津", 0));
            Provinces.Add(3, new RegionDivision(3, 0, "河北省", 0));
            Provinces.Add(4, new RegionDivision(4, 0, "山西省", 0));
            Provinces.Add(5, new RegionDivision(5, 0, "内蒙古自治区", 0));
            Provinces.Add(6, new RegionDivision(6, 0, "辽宁省", 0));
            Provinces.Add(7, new RegionDivision(7, 0, "吉林省", 0));
            Provinces.Add(8, new RegionDivision(8, 0, "黑龙江省", 0));
            Provinces.Add(9, new RegionDivision(9, 0, "上海", 0));
            Provinces.Add(10, new RegionDivision(10, 0, "江苏省", 0));
            Provinces.Add(11, new RegionDivision(11, 0, "浙江省", 0));
            Provinces.Add(12, new RegionDivision(12, 0, "安徽省", 0));
            Provinces.Add(13, new RegionDivision(13, 0, "福建省", 0));
            Provinces.Add(14, new RegionDivision(14, 0, "江西省", 0));
            Provinces.Add(15, new RegionDivision(15, 0, "山东省", 0));
            Provinces.Add(16, new RegionDivision(16, 0, "河南省", 0));
            Provinces.Add(17, new RegionDivision(17, 0, "湖北省", 0));
            Provinces.Add(18, new RegionDivision(18, 0, "湖南省", 0));
            Provinces.Add(19, new RegionDivision(19, 0, "广东省", 0));
            Provinces.Add(20, new RegionDivision(20, 0, "广西壮族自治区", 0));
            Provinces.Add(21, new RegionDivision(21, 0, "海南省", 0));
            Provinces.Add(22, new RegionDivision(22, 0, "重庆", 0));
            Provinces.Add(23, new RegionDivision(23, 0, "四川省", 0));
            Provinces.Add(24, new RegionDivision(24, 0, "贵州省", 0));
            Provinces.Add(25, new RegionDivision(25, 0, "云南省", 0));
            Provinces.Add(26, new RegionDivision(26, 0, "西藏自治区", 0));
            Provinces.Add(27, new RegionDivision(27, 0, "陕西省", 0));
            Provinces.Add(28, new RegionDivision(28, 0, "甘肃省", 0));
            Provinces.Add(29, new RegionDivision(29, 0, "青海省", 0));
            Provinces.Add(30, new RegionDivision(30, 0, "宁夏回族自治区", 0));
            Provinces.Add(31, new RegionDivision(31, 0, "新疆维吾尔自治区", 0));
            Provinces.Add(32, new RegionDivision(32, 0, "台湾省", 0));
            Provinces.Add(33, new RegionDivision(33, 0, "香港特别行政区", 0));
            Provinces.Add(34, new RegionDivision(34, 0, "澳门特别行政区", 0));
            Provinces.Add(35, new RegionDivision(35, 0, "海外", 0));

        }

        /// <summary>
        /// 根据 ID 查找指定的地址属性.
        /// </summary>
        /// <param name="address">地址信息.</param>
        /// <param name="id">行政区划的 ID.</param>
        /// <param name="prop">要查找的地址属性.</param>
        /// <returns></returns>
        public AddressInformation FindById(AddressInformation address, int id, DivisionSearchProperty prop)
        {
            RegionDivision division = null;
            switch (prop)
            {
                case DivisionSearchProperty.Province:
                    if (Provinces.TryGetValue(id, out division))
                        address.province = division.name;
                    break;
                case DivisionSearchProperty.City:
                    if (Citys.TryGetValue(id, out division))
                    {
                        address.city = division.name;
                        FindById(address, division.pid, DivisionSearchProperty.Province);
                    }
                    break;
                case DivisionSearchProperty.Area:
                    if (Areas.TryGetValue(id, out division))
                    {
                        address.area = division.name;
                        FindById(address, division.pid, DivisionSearchProperty.City);
                    }
                    break;
            }
            return address;
        }

        #region IDisposable成员实现

        /// <summary>
        /// 释放该对象占用的资源.
        /// </summary>
        /// <param name="disposing">手动调用则为 true，由对象终结器调用则为 false .</param>
        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                Provinces.Clear();
                Citys.Clear();
                Areas.Clear();
            }
            Provinces = null;
            Citys = null;
            Areas = null;
        }

        /// <summary>
        /// 释放对象占用的资源.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            // 手动释放时请求运行时的 GC 回收器不必调用该对象的结象终结器（即析构函数）.
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// 对象结终器（析构函数）.
        /// </summary>
        ~RegionDivisionsTables()
        {
            Dispose(false);
        }
        #endregion
    }
}
