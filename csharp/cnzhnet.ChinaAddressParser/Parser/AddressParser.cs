using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace cnzhnet.ChinaAddressParser
{
    /// <summary>
    /// 中华人民共和国地址智能解析器.
    /// </summary>
    public class AddressParser : IDisposable
    {
        private RegionDivisionsTables tables;
        private const string province_pattern = @".+?(省|市|自治区|特别行政区|区)";
        private const string city_pattern = @".+?(省|市|自治州|州|地区|盟|县|自治县|区|林区)";
        private const string area_pattern = @".+?(市|县|自治县|旗|自治旗|区|林区|特区|街道|镇|乡)";

        /// <summary>
        /// 创建一个 <see cref="AddressParser"/> 的地址解析器.
        /// </summary>
        public AddressParser()
        {
            tables = new RegionDivisionsTables();
        }

        /// <summary>
        /// 解析地址信息.
        /// </summary>
        /// <param name="address">要解析的地址字符串.</param>
        /// <returns></returns>
        public AddressInformation Parse(string address)
        {
            AddressInformation info = new AddressInformation();
            if (string.IsNullOrEmpty(address))
                return info;
            Parse(address, info);
            if (string.IsNullOrEmpty(info.province) && string.IsNullOrEmpty(info.city) && string.IsNullOrEmpty(info.area))
            {
                info.street = address;
                return info;
            }
            int index;
            if (!string.IsNullOrEmpty(info.area))
            {
                index = address.LastIndexOf(info.area) + info.area.Length;
                info.street = address.Substring(index);
                return info;
            }
            if (!string.IsNullOrEmpty(info.city))
            {
                index = address.LastIndexOf(info.city) + info.city.Length;
                info.street = address.Substring(index);
                return info;
            }
            if (!string.IsNullOrEmpty(info.province))
            {
                index = address.LastIndexOf(info.province) + info.province.Length;
                info.street = address.Substring(index);
            }
            return info;
        }

        protected virtual void Parse(string address, AddressInformation info)
        {
            List<string> keywords = new List<string>();
            MatchCollection matches = Regex.Matches(address, province_pattern, RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture);
            if (matches.Count > 0)
                keywords.AddRange(matches.Select(m => m.Value).ToArray());
            matches = Regex.Matches(address, city_pattern, RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture);
            if (matches.Count > 0)
                keywords.AddRange(matches.Select(m => m.Value).ToArray());
            matches = Regex.Matches(address, area_pattern, RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture);
            if (matches.Count > 0)
                keywords.AddRange(matches.Select(m => m.Value).ToArray());
            IEnumerable<KeyValuePair<int, RegionDivision>> results;
            RegionDivision find;
            bool passArea = false, passCity = false;
            int index = keywords.Count - 1, i = 0;
            while (index >= 0)
            {
                // 搜索所有区县级.
                if (!passArea)
                {
                    for (i = index; i >= 0; --i)
                    {
                        results = tables.Areas.Where(p => p.Value.name.Contains(keywords[i]));
                        if (results == null || results.Count() < 1)
                            continue;
                        find = results.First().Value;
                        info.area = find.name;
                        tables.FindById(info, find.pid, DivisionSearchProperty.City);
                        index = i;
                        break;
                    }
                    passArea = true;
                }
                // 搜索所有省辖市（区县级名称有可能同名，故此处仍然需要继续修正省辖市）.
                if (!passCity)
                {
                    for (i = index; i >= 0; --i)
                    {
                        results = tables.Citys.Where(p => p.Value.name.Contains(keywords[i]));
                        if (results == null || results.Count() < 1)
                            continue;
                        find = results.First().Value;
                        info.city = find.name;
                        tables.FindById(info, find.pid, DivisionSearchProperty.Province);
                        index = i;
                        break;
                    }
                    passCity = true;
                }
                // 搜索所有省（不同省的辖市名称有可能相同，此处仍然需要继续修正省）.
                for (i = index; i >= 0; --i)
                {
                    results = tables.Provinces.Where(p => p.Value.name.Contains(keywords[i]));
                    if (results == null || results.Count() < 1)
                        continue;
                    find = results.First().Value;
                    info.province = find.name;
                    break;
                }
                index = -1;
            }
        }

        #region IDisposable成员实现

        /// <summary>
        /// 释放该对象占用的资源.
        /// </summary>
        /// <param name="disposing">手动调用则为 true，由对象终结器调用则为 false .</param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                tables.Dispose();
            }
            tables = null;
        }

        /// <summary>
        /// 释放该对象占用的资源.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// 对象结终器（析构函数）.
        /// </summary>
        ~AddressParser()
        {
            Dispose(false);
        }
        #endregion
    }
}
