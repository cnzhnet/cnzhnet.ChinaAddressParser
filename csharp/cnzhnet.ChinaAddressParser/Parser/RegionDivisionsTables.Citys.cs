using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnzhnet.ChinaAddressParser
{
    public partial class RegionDivisionsTables
    {
        /// <summary>
        /// 初始化二级行政区划的数据.
        /// </summary>
        private void InitCitys() 
        {
            Citys.Add(36, new RegionDivision(36, 1, "北京市", 100000));
            Citys.Add(39, new RegionDivision(39, 9, "上海市", 200000));
            Citys.Add(40, new RegionDivision(40, 2, "天津市", 300000));
            Citys.Add(62, new RegionDivision(62, 22, "重庆市", 404100));
            Citys.Add(73, new RegionDivision(73, 3, "石家庄市", 50000));
            Citys.Add(74, new RegionDivision(74, 3, "唐山市", 63000));
            Citys.Add(75, new RegionDivision(75, 3, "秦皇岛市", 66000));
            Citys.Add(76, new RegionDivision(76, 3, "邯郸市", 56000));
            Citys.Add(77, new RegionDivision(77, 3, "邢台市", 54000));
            Citys.Add(78, new RegionDivision(78, 3, "保定市", 71000));
            Citys.Add(79, new RegionDivision(79, 3, "张家口市", 75000));
            Citys.Add(80, new RegionDivision(80, 3, "承德市", 67400));
            Citys.Add(81, new RegionDivision(81, 3, "衡水市", 53000));
            Citys.Add(82, new RegionDivision(82, 3, "廊坊市", 65000));
            Citys.Add(83, new RegionDivision(83, 3, "沧州市", 61000));
            Citys.Add(84, new RegionDivision(84, 4, "太原市", 30000));
            Citys.Add(85, new RegionDivision(85, 4, "大同市", 163000));
            Citys.Add(86, new RegionDivision(86, 4, "阳泉市", 45000));
            Citys.Add(87, new RegionDivision(87, 4, "长治市", 46000));
            Citys.Add(88, new RegionDivision(88, 4, "晋城市", 48000));
            Citys.Add(89, new RegionDivision(89, 4, "朔州市", 36000));
            Citys.Add(90, new RegionDivision(90, 4, "晋中市", 30600));
            Citys.Add(91, new RegionDivision(91, 4, "运城市", 44000));
            Citys.Add(92, new RegionDivision(92, 4, "忻州市", 34000));
            Citys.Add(93, new RegionDivision(93, 4, "临汾市", 41000));
            Citys.Add(94, new RegionDivision(94, 4, "吕梁市", 33000));
            Citys.Add(95, new RegionDivision(95, 5, "呼和浩特市", 10000));
            Citys.Add(96, new RegionDivision(96, 5, "包头市", 14000));
            Citys.Add(97, new RegionDivision(97, 5, "乌海市", 16000));
            Citys.Add(98, new RegionDivision(98, 5, "赤峰市", 24000));
            Citys.Add(99, new RegionDivision(99, 5, "通辽市", 28000));
            Citys.Add(100, new RegionDivision(100, 5, "鄂尔多斯市", 17000));
            Citys.Add(101, new RegionDivision(101, 5, "呼伦贝尔市", 21000));
            Citys.Add(102, new RegionDivision(102, 5, "巴彦淖尔市", 15000));
            Citys.Add(103, new RegionDivision(103, 5, "乌兰察布市", 12000));
            Citys.Add(104, new RegionDivision(104, 5, "兴安盟", 137400));
            Citys.Add(105, new RegionDivision(105, 5, "锡林郭勒盟", 26000));
            Citys.Add(106, new RegionDivision(106, 5, "阿拉善盟", 16055));
            Citys.Add(107, new RegionDivision(107, 6, "沈阳市", 110000));
            Citys.Add(108, new RegionDivision(108, 6, "大连市", 116000));
            Citys.Add(109, new RegionDivision(109, 6, "鞍山市", 114000));
            Citys.Add(110, new RegionDivision(110, 6, "抚顺市", 113100));
            Citys.Add(111, new RegionDivision(111, 6, "本溪市", 117100));
            Citys.Add(112, new RegionDivision(112, 6, "丹东市", 118000));
            Citys.Add(113, new RegionDivision(113, 6, "锦州市", 121000));
            Citys.Add(114, new RegionDivision(114, 6, "营口市", 115000));
            Citys.Add(115, new RegionDivision(115, 6, "阜新市", 123100));
            Citys.Add(116, new RegionDivision(116, 6, "辽阳市", 111200));
            Citys.Add(117, new RegionDivision(117, 6, "盘锦市", 124000));
            Citys.Add(118, new RegionDivision(118, 6, "铁岭市", 112600));
            Citys.Add(119, new RegionDivision(119, 6, "朝阳市", 122000));
            Citys.Add(120, new RegionDivision(120, 6, "葫芦岛市", 125000));
            Citys.Add(121, new RegionDivision(121, 7, "长春市", 130000));
            Citys.Add(122, new RegionDivision(122, 7, "吉林市", 132013));
            Citys.Add(123, new RegionDivision(123, 7, "四平市", 136000));
            Citys.Add(124, new RegionDivision(124, 7, "辽源市", 136200));
            Citys.Add(125, new RegionDivision(125, 7, "通化市", 134100));
            Citys.Add(126, new RegionDivision(126, 7, "白山市", 134300));
            Citys.Add(127, new RegionDivision(127, 7, "松原市", 138000));
            Citys.Add(128, new RegionDivision(128, 7, "白城市", 137000));
            Citys.Add(129, new RegionDivision(129, 7, "延边朝鲜族自治州", 133000));
            Citys.Add(130, new RegionDivision(130, 8, "哈尔滨市", 150000));
            Citys.Add(131, new RegionDivision(131, 8, "齐齐哈尔市", 161000));
            Citys.Add(132, new RegionDivision(132, 8, "鸡西市", 158100));
            Citys.Add(133, new RegionDivision(133, 8, "鹤岗市", 154100));
            Citys.Add(134, new RegionDivision(134, 8, "双鸭山市", 155100));
            Citys.Add(135, new RegionDivision(135, 8, "大庆市", 163000));
            Citys.Add(136, new RegionDivision(136, 8, "伊春市", 153000));
            Citys.Add(137, new RegionDivision(137, 8, "佳木斯市", 154000));
            Citys.Add(138, new RegionDivision(138, 8, "七台河市", 154600));
            Citys.Add(139, new RegionDivision(139, 8, "牡丹江市", 157000));
            Citys.Add(140, new RegionDivision(140, 8, "黑河市", 164300));
            Citys.Add(141, new RegionDivision(141, 8, "绥化市", 152000));
            Citys.Add(142, new RegionDivision(142, 8, "大兴安岭地区", 165000));
            Citys.Add(162, new RegionDivision(162, 10, "南京市", 210000));
            Citys.Add(163, new RegionDivision(163, 10, "无锡市", 214000));
            Citys.Add(164, new RegionDivision(164, 10, "徐州市", 221000));
            Citys.Add(165, new RegionDivision(165, 10, "常州市", 213000));
            Citys.Add(166, new RegionDivision(166, 10, "苏州市", 215000));
            Citys.Add(167, new RegionDivision(167, 10, "南通市", 226000));
            Citys.Add(168, new RegionDivision(168, 10, "连云港市", 222000));
            Citys.Add(169, new RegionDivision(169, 10, "淮安市", 223001));
            Citys.Add(170, new RegionDivision(170, 10, "盐城市", 224000));
            Citys.Add(171, new RegionDivision(171, 10, "扬州市", 225000));
            Citys.Add(172, new RegionDivision(172, 10, "镇江市", 212000));
            Citys.Add(173, new RegionDivision(173, 10, "泰州市", 225300));
            Citys.Add(174, new RegionDivision(174, 10, "宿迁市", 223800));
            Citys.Add(175, new RegionDivision(175, 11, "杭州市", 310000));
            Citys.Add(176, new RegionDivision(176, 11, "宁波市", 315000));
            Citys.Add(177, new RegionDivision(177, 11, "温州市", 325000));
            Citys.Add(178, new RegionDivision(178, 11, "嘉兴市", 314000));
            Citys.Add(179, new RegionDivision(179, 11, "湖州市", 313000));
            Citys.Add(180, new RegionDivision(180, 11, "绍兴市", 312000));
            Citys.Add(181, new RegionDivision(181, 11, "舟山市", 316000));
            Citys.Add(182, new RegionDivision(182, 11, "衢州市", 324000));
            Citys.Add(183, new RegionDivision(183, 11, "金华市", 321000));
            Citys.Add(184, new RegionDivision(184, 11, "台州市", 318000));
            Citys.Add(185, new RegionDivision(185, 11, "丽水市", 323000));
            Citys.Add(186, new RegionDivision(186, 12, "合肥市", 230000));
            Citys.Add(187, new RegionDivision(187, 12, "芜湖市", 241100));
            Citys.Add(188, new RegionDivision(188, 12, "蚌埠市", 233000));
            Citys.Add(189, new RegionDivision(189, 12, "淮南市", 232000));
            Citys.Add(190, new RegionDivision(190, 12, "马鞍山市", 243000));
            Citys.Add(191, new RegionDivision(191, 12, "淮北市", 235000));
            Citys.Add(192, new RegionDivision(192, 12, "铜陵市", 244100));
            Citys.Add(193, new RegionDivision(193, 12, "安庆市", 246000));
            Citys.Add(194, new RegionDivision(194, 12, "黄山市", 245000));
            Citys.Add(195, new RegionDivision(195, 12, "滁州市", 239000));
            Citys.Add(196, new RegionDivision(196, 12, "阜阳市", 236000));
            Citys.Add(197, new RegionDivision(197, 12, "宿州市", 234000));
            Citys.Add(198, new RegionDivision(198, 12, "巢湖市", 238000));
            Citys.Add(199, new RegionDivision(199, 12, "六安市", 237000));
            Citys.Add(200, new RegionDivision(200, 12, "亳州市", 236000));
            Citys.Add(201, new RegionDivision(201, 12, "池州市", 247100));
            Citys.Add(202, new RegionDivision(202, 12, "宣城市", 242000));
            Citys.Add(203, new RegionDivision(203, 13, "福州市", 350000));
            Citys.Add(204, new RegionDivision(204, 13, "厦门市", 361000));
            Citys.Add(205, new RegionDivision(205, 13, "莆田市", 351100));
            Citys.Add(206, new RegionDivision(206, 13, "三明市", 365000));
            Citys.Add(207, new RegionDivision(207, 13, "泉州市", 362000));
            Citys.Add(208, new RegionDivision(208, 13, "漳州市", 363000));
            Citys.Add(209, new RegionDivision(209, 13, "南平市", 353000));
            Citys.Add(210, new RegionDivision(210, 13, "龙岩市", 364000));
            Citys.Add(211, new RegionDivision(211, 13, "宁德市", 352000));
            Citys.Add(212, new RegionDivision(212, 14, "南昌市", 330200));
            Citys.Add(213, new RegionDivision(213, 14, "景德镇市", 333000));
            Citys.Add(214, new RegionDivision(214, 14, "萍乡市", 337000));
            Citys.Add(215, new RegionDivision(215, 14, "九江市", 332100));
            Citys.Add(216, new RegionDivision(216, 14, "新余市", 338000));
            Citys.Add(217, new RegionDivision(217, 14, "鹰潭市", 335000));
            Citys.Add(218, new RegionDivision(218, 14, "赣州市", 341000));
            Citys.Add(219, new RegionDivision(219, 14, "吉安市", 343100));
            Citys.Add(220, new RegionDivision(220, 14, "宜春市", 336000));
            Citys.Add(221, new RegionDivision(221, 14, "抚州市", 344000));
            Citys.Add(222, new RegionDivision(222, 14, "上饶市", 334100));
            Citys.Add(223, new RegionDivision(223, 15, "济南市", 250000));
            Citys.Add(224, new RegionDivision(224, 15, "青岛市", 266000));
            Citys.Add(225, new RegionDivision(225, 15, "淄博市", 255000));
            Citys.Add(226, new RegionDivision(226, 15, "枣庄市", 277000));
            Citys.Add(227, new RegionDivision(227, 15, "东营市", 257100));
            Citys.Add(228, new RegionDivision(228, 15, "烟台市", 264000));
            Citys.Add(229, new RegionDivision(229, 15, "潍坊市", 261000));
            Citys.Add(230, new RegionDivision(230, 15, "济宁市", 272000));
            Citys.Add(231, new RegionDivision(231, 15, "泰安市", 271000));
            Citys.Add(232, new RegionDivision(232, 15, "威海市", 264200));
            Citys.Add(233, new RegionDivision(233, 15, "日照市", 276800));
            Citys.Add(234, new RegionDivision(234, 15, "莱芜市", 271100));
            Citys.Add(235, new RegionDivision(235, 15, "临沂市", 276000));
            Citys.Add(236, new RegionDivision(236, 15, "德州市", 253000));
            Citys.Add(237, new RegionDivision(237, 15, "聊城市", 252000));
            Citys.Add(238, new RegionDivision(238, 15, "滨州市", 256600));
            Citys.Add(239, new RegionDivision(239, 15, "菏泽市", 274000));
            Citys.Add(240, new RegionDivision(240, 16, "郑州市", 450000));
            Citys.Add(241, new RegionDivision(241, 16, "开封市", 475100));
            Citys.Add(242, new RegionDivision(242, 16, "洛阳市", 471000));
            Citys.Add(243, new RegionDivision(243, 16, "平顶山市", 467000));
            Citys.Add(244, new RegionDivision(244, 16, "安阳市", 455100));
            Citys.Add(245, new RegionDivision(245, 16, "鹤壁市", 458000));
            Citys.Add(246, new RegionDivision(246, 16, "新乡市", 453700));
            Citys.Add(247, new RegionDivision(247, 16, "焦作市", 454150));
            Citys.Add(248, new RegionDivision(248, 16, "濮阳市", 457100));
            Citys.Add(249, new RegionDivision(249, 16, "许昌市", 461100));
            Citys.Add(250, new RegionDivision(250, 16, "漯河市", 462000));
            Citys.Add(251, new RegionDivision(251, 16, "三门峡市", 472000));
            Citys.Add(252, new RegionDivision(252, 16, "南阳市", 473000));
            Citys.Add(253, new RegionDivision(253, 16, "商丘市", 476000));
            Citys.Add(254, new RegionDivision(254, 16, "信阳市", 464000));
            Citys.Add(255, new RegionDivision(255, 16, "周口市", 466000));
            Citys.Add(256, new RegionDivision(256, 16, "驻马店市", 463000));
            Citys.Add(257, new RegionDivision(257, 16, "济源市", 454650));
            Citys.Add(258, new RegionDivision(258, 17, "武汉市", 430000));
            Citys.Add(259, new RegionDivision(259, 17, "黄石市", 435000));
            Citys.Add(260, new RegionDivision(260, 17, "十堰市", 442000));
            Citys.Add(261, new RegionDivision(261, 17, "宜昌市", 443000));
            Citys.Add(262, new RegionDivision(262, 17, "襄阳市", 441100));
            Citys.Add(263, new RegionDivision(263, 17, "鄂州市", 436000));
            Citys.Add(264, new RegionDivision(264, 17, "荆门市", 448000));
            Citys.Add(265, new RegionDivision(265, 17, "孝感市", 432000));
            Citys.Add(266, new RegionDivision(266, 17, "荆州市", 434020));
            Citys.Add(267, new RegionDivision(267, 17, "黄冈市", 438000));
            Citys.Add(268, new RegionDivision(268, 17, "咸宁市", 437000));
            Citys.Add(269, new RegionDivision(269, 17, "随州市", 441300));
            Citys.Add(270, new RegionDivision(270, 17, "恩施土家族苗族自治州", 445000));
            Citys.Add(271, new RegionDivision(271, 17, "仙桃市", 433000));
            Citys.Add(272, new RegionDivision(272, 17, "潜江市", 433100));
            Citys.Add(273, new RegionDivision(273, 17, "天门市", 431700));
            Citys.Add(274, new RegionDivision(274, 17, "神农架林区", 442400));
            Citys.Add(275, new RegionDivision(275, 18, "长沙市", 410000));
            Citys.Add(276, new RegionDivision(276, 18, "株洲市", 412000));
            Citys.Add(277, new RegionDivision(277, 18, "湘潭市", 411200));
            Citys.Add(278, new RegionDivision(278, 18, "衡阳市", 421200));
            Citys.Add(279, new RegionDivision(279, 18, "邵阳市", 422100));
            Citys.Add(280, new RegionDivision(280, 18, "岳阳市", 414100));
            Citys.Add(281, new RegionDivision(281, 18, "常德市", 415000));
            Citys.Add(282, new RegionDivision(282, 18, "张家界市", 427000));
            Citys.Add(283, new RegionDivision(283, 18, "益阳市", 413000));
            Citys.Add(284, new RegionDivision(284, 18, "郴州市", 423000));
            Citys.Add(285, new RegionDivision(285, 18, "永州市", 425000));
            Citys.Add(286, new RegionDivision(286, 18, "怀化市", 418000));
            Citys.Add(287, new RegionDivision(287, 18, "娄底市", 417000));
            Citys.Add(288, new RegionDivision(288, 18, "湘西土家族苗族自治州", 416000));
            Citys.Add(289, new RegionDivision(289, 19, "广州市", 510000));
            Citys.Add(290, new RegionDivision(290, 19, "韶关市", 512000));
            Citys.Add(291, new RegionDivision(291, 19, "深圳市", 518000));
            Citys.Add(292, new RegionDivision(292, 19, "珠海市", 519000));
            Citys.Add(293, new RegionDivision(293, 19, "汕头市", 515000));
            Citys.Add(294, new RegionDivision(294, 19, "佛山市", 528000));
            Citys.Add(295, new RegionDivision(295, 19, "江门市", 529000));
            Citys.Add(296, new RegionDivision(296, 19, "湛江市", 524000));
            Citys.Add(297, new RegionDivision(297, 19, "茂名市", 525000));
            Citys.Add(298, new RegionDivision(298, 19, "肇庆市", 526000));
            Citys.Add(299, new RegionDivision(299, 19, "惠州市", 516000));
            Citys.Add(300, new RegionDivision(300, 19, "梅州市", 514000));
            Citys.Add(301, new RegionDivision(301, 19, "汕尾市", 516600));
            Citys.Add(302, new RegionDivision(302, 19, "河源市", 517000));
            Citys.Add(303, new RegionDivision(303, 19, "阳江市", 529500));
            Citys.Add(304, new RegionDivision(304, 19, "清远市", 511500));
            Citys.Add(305, new RegionDivision(305, 19, "东莞市", 523000));
            Citys.Add(306, new RegionDivision(306, 19, "中山市", 116000));
            Citys.Add(307, new RegionDivision(307, 19, "潮州市", 521000));
            Citys.Add(308, new RegionDivision(308, 19, "揭阳市", 522000));
            Citys.Add(309, new RegionDivision(309, 19, "云浮市", 527300));
            Citys.Add(310, new RegionDivision(310, 20, "南宁市", 530000));
            Citys.Add(311, new RegionDivision(311, 20, "柳州市", 545000));
            Citys.Add(312, new RegionDivision(312, 20, "桂林市", 541000));
            Citys.Add(313, new RegionDivision(313, 20, "梧州市", 543000));
            Citys.Add(314, new RegionDivision(314, 20, "北海市", 536000));
            Citys.Add(315, new RegionDivision(315, 20, "防城港市", 538000));
            Citys.Add(316, new RegionDivision(316, 20, "钦州市", 535000));
            Citys.Add(317, new RegionDivision(317, 20, "贵港市", 537000));
            Citys.Add(318, new RegionDivision(318, 20, "玉林市", 537000));
            Citys.Add(319, new RegionDivision(319, 20, "百色市", 533000));
            Citys.Add(320, new RegionDivision(320, 20, "贺州市", 542800));
            Citys.Add(321, new RegionDivision(321, 20, "河池市", 547000));
            Citys.Add(322, new RegionDivision(322, 20, "来宾市", 546100));
            Citys.Add(323, new RegionDivision(323, 20, "崇左市", 532200));
            Citys.Add(324, new RegionDivision(324, 21, "海口市", 570100));
            Citys.Add(325, new RegionDivision(325, 21, "三亚市", 572000));
            Citys.Add(326, new RegionDivision(326, 21, "五指山市", 572200));
            Citys.Add(327, new RegionDivision(327, 21, "琼海市", 571400));
            Citys.Add(328, new RegionDivision(328, 21, "儋州市", 571700));
            Citys.Add(329, new RegionDivision(329, 21, "文昌市", 571300));
            Citys.Add(330, new RegionDivision(330, 21, "万宁市", 571500));
            Citys.Add(331, new RegionDivision(331, 21, "东方市", 572600));
            Citys.Add(332, new RegionDivision(332, 21, "定安县", 571229));
            Citys.Add(333, new RegionDivision(333, 21, "屯昌县", 571600));
            Citys.Add(334, new RegionDivision(334, 21, "澄迈县", 571900));
            Citys.Add(335, new RegionDivision(335, 21, "临高县", 571800));
            Citys.Add(336, new RegionDivision(336, 21, "白沙黎族自治县", 572800));
            Citys.Add(337, new RegionDivision(337, 21, "昌江黎族自治县", 572700));
            Citys.Add(338, new RegionDivision(338, 21, "乐东黎族自治县", 572500));
            Citys.Add(339, new RegionDivision(339, 21, "陵水黎族自治县", 572400));
            Citys.Add(340, new RegionDivision(340, 21, "保亭黎族苗族自治县", 572300));
            Citys.Add(341, new RegionDivision(341, 21, "琼中黎族苗族自治县", 572900));
            Citys.Add(342, new RegionDivision(342, 21, "西沙群岛", 572000));
            Citys.Add(343, new RegionDivision(343, 21, "南沙群岛", 0));
            Citys.Add(344, new RegionDivision(344, 21, "中沙群岛的岛礁及其海域", 0));
            Citys.Add(385, new RegionDivision(385, 23, "成都市", 610000));
            Citys.Add(386, new RegionDivision(386, 23, "自贡市", 643000));
            Citys.Add(387, new RegionDivision(387, 23, "攀枝花市", 617000));
            Citys.Add(388, new RegionDivision(388, 23, "泸州市", 646000));
            Citys.Add(389, new RegionDivision(389, 23, "德阳市", 618000));
            Citys.Add(390, new RegionDivision(390, 23, "绵阳市", 621000));
            Citys.Add(391, new RegionDivision(391, 23, "广元市", 628000));
            Citys.Add(392, new RegionDivision(392, 23, "遂宁市", 629000));
            Citys.Add(393, new RegionDivision(393, 23, "内江市", 641000));
            Citys.Add(394, new RegionDivision(394, 23, "乐山市", 614000));
            Citys.Add(395, new RegionDivision(395, 23, "南充市", 637000));
            Citys.Add(396, new RegionDivision(396, 23, "眉山市", 620000));
            Citys.Add(397, new RegionDivision(397, 23, "宜宾市", 644600));
            Citys.Add(398, new RegionDivision(398, 23, "广安市", 638550));
            Citys.Add(399, new RegionDivision(399, 23, "达州市", 635000));
            Citys.Add(400, new RegionDivision(400, 23, "雅安市", 625000));
            Citys.Add(401, new RegionDivision(401, 23, "巴中市", 636600));
            Citys.Add(402, new RegionDivision(402, 23, "资阳市", 641300));
            Citys.Add(403, new RegionDivision(403, 23, "阿坝藏族羌族自治州", 624600));
            Citys.Add(404, new RegionDivision(404, 23, "甘孜藏族自治州", 626700));
            Citys.Add(405, new RegionDivision(405, 23, "凉山彝族自治州", 615000));
            Citys.Add(406, new RegionDivision(406, 24, "贵阳市", 550000));
            Citys.Add(407, new RegionDivision(407, 24, "六盘水市", 553000));
            Citys.Add(408, new RegionDivision(408, 24, "遵义市", 563100));
            Citys.Add(409, new RegionDivision(409, 24, "安顺市", 561000));
            Citys.Add(410, new RegionDivision(410, 24, "铜仁地区", 554300));
            Citys.Add(411, new RegionDivision(411, 24, "黔西南布依族苗族自治州", 562400));
            Citys.Add(412, new RegionDivision(412, 24, "毕节地区", 551700));
            Citys.Add(413, new RegionDivision(413, 24, "黔东南苗族侗族自治州", 556000));
            Citys.Add(414, new RegionDivision(414, 24, "黔南布依族苗族自治州", 558000));
            Citys.Add(415, new RegionDivision(415, 25, "昆明市", 650000));
            Citys.Add(416, new RegionDivision(416, 25, "曲靖市", 655000));
            Citys.Add(417, new RegionDivision(417, 25, "玉溪市", 653100));
            Citys.Add(418, new RegionDivision(418, 25, "保山市", 678000));
            Citys.Add(419, new RegionDivision(419, 25, "昭通市", 657000));
            Citys.Add(420, new RegionDivision(420, 25, "丽江市", 674100));
            Citys.Add(421, new RegionDivision(421, 25, "思茅市", 665001));
            Citys.Add(422, new RegionDivision(422, 25, "临沧市", 677000));
            Citys.Add(423, new RegionDivision(423, 25, "楚雄彝族自治州", 675000));
            Citys.Add(424, new RegionDivision(424, 25, "红河哈尼族彝族自治州", 654400));
            Citys.Add(425, new RegionDivision(425, 25, "文山壮族苗族自治州", 663000));
            Citys.Add(426, new RegionDivision(426, 25, "西双版纳傣族自治州", 666100));
            Citys.Add(427, new RegionDivision(427, 25, "大理白族自治州", 671000));
            Citys.Add(428, new RegionDivision(428, 25, "德宏傣族景颇族自治州", 678400));
            Citys.Add(429, new RegionDivision(429, 25, "怒江傈僳族自治州", 673100));
            Citys.Add(430, new RegionDivision(430, 25, "迪庆藏族自治州", 674400));
            Citys.Add(431, new RegionDivision(431, 26, "拉萨市", 850000));
            Citys.Add(432, new RegionDivision(432, 26, "昌都地区", 854000));
            Citys.Add(433, new RegionDivision(433, 26, "山南地区", 856000));
            Citys.Add(434, new RegionDivision(434, 26, "日喀则地区", 857000));
            Citys.Add(435, new RegionDivision(435, 26, "那曲地区", 852000));
            Citys.Add(436, new RegionDivision(436, 26, "阿里地区", 859000));
            Citys.Add(437, new RegionDivision(437, 26, "林芝地区", 860100));
            Citys.Add(438, new RegionDivision(438, 27, "西安市", 710000));
            Citys.Add(439, new RegionDivision(439, 27, "铜川市", 727000));
            Citys.Add(440, new RegionDivision(440, 27, "宝鸡市", 721000));
            Citys.Add(441, new RegionDivision(441, 27, "咸阳市", 712000));
            Citys.Add(442, new RegionDivision(442, 27, "渭南市", 714000));
            Citys.Add(443, new RegionDivision(443, 27, "延安市", 716000));
            Citys.Add(444, new RegionDivision(444, 27, "汉中市", 723000));
            Citys.Add(445, new RegionDivision(445, 27, "榆林市", 719000));
            Citys.Add(446, new RegionDivision(446, 27, "安康市", 725000));
            Citys.Add(447, new RegionDivision(447, 27, "商洛市", 726000));
            Citys.Add(448, new RegionDivision(448, 28, "兰州市", 730000));
            Citys.Add(449, new RegionDivision(449, 28, "嘉峪关市", 735100));
            Citys.Add(450, new RegionDivision(450, 28, "金昌市", 737100));
            Citys.Add(451, new RegionDivision(451, 28, "白银市", 730900));
            Citys.Add(452, new RegionDivision(452, 28, "天水市", 741000));
            Citys.Add(453, new RegionDivision(453, 28, "武威市", 733000));
            Citys.Add(454, new RegionDivision(454, 28, "张掖市", 734000));
            Citys.Add(455, new RegionDivision(455, 28, "平凉市", 744000));
            Citys.Add(456, new RegionDivision(456, 28, "酒泉市", 735000));
            Citys.Add(457, new RegionDivision(457, 28, "庆阳市", 745000));
            Citys.Add(458, new RegionDivision(458, 28, "定西市", 743000));
            Citys.Add(459, new RegionDivision(459, 28, "陇南市", 742500));
            Citys.Add(460, new RegionDivision(460, 28, "临夏回族自治州", 731800));
            Citys.Add(461, new RegionDivision(461, 28, "甘南藏族自治州", 747000));
            Citys.Add(462, new RegionDivision(462, 29, "西宁市", 810000));
            Citys.Add(463, new RegionDivision(463, 29, "海东地区", 810600));
            Citys.Add(464, new RegionDivision(464, 29, "海北藏族自治州", 812200));
            Citys.Add(465, new RegionDivision(465, 29, "黄南藏族自治州", 811300));
            Citys.Add(466, new RegionDivision(466, 29, "海南藏族自治州", 813000));
            Citys.Add(467, new RegionDivision(467, 29, "果洛藏族自治州", 814000));
            Citys.Add(468, new RegionDivision(468, 29, "玉树藏族自治州", 815000));
            Citys.Add(469, new RegionDivision(469, 29, "海西蒙古族藏族自治州", 817000));
            Citys.Add(470, new RegionDivision(470, 30, "银川市", 750000));
            Citys.Add(471, new RegionDivision(471, 30, "石嘴山市", 753000));
            Citys.Add(472, new RegionDivision(472, 30, "吴忠市", 751100));
            Citys.Add(473, new RegionDivision(473, 30, "固原市", 756000));
            Citys.Add(474, new RegionDivision(474, 30, "中卫市", 755000));
            Citys.Add(475, new RegionDivision(475, 31, "乌鲁木齐市", 830000));
            Citys.Add(476, new RegionDivision(476, 31, "克拉玛依市", 834000));
            Citys.Add(477, new RegionDivision(477, 31, "吐鲁番地区", 838000));
            Citys.Add(478, new RegionDivision(478, 31, "哈密地区", 839000));
            Citys.Add(479, new RegionDivision(479, 31, "昌吉回族自治州", 831100));
            Citys.Add(480, new RegionDivision(480, 31, "博尔塔拉蒙古自治州", 833400));
            Citys.Add(481, new RegionDivision(481, 31, "巴音郭楞蒙古自治州", 841000));
            Citys.Add(482, new RegionDivision(482, 31, "阿克苏地区", 843000));
            Citys.Add(483, new RegionDivision(483, 31, "克孜勒苏柯尔克孜自治州", 845350));
            Citys.Add(484, new RegionDivision(484, 31, "喀什地区", 844000));
            Citys.Add(485, new RegionDivision(485, 31, "和田地区", 848000));
            Citys.Add(486, new RegionDivision(486, 31, "伊犁哈萨克自治州", 835000));
            Citys.Add(487, new RegionDivision(487, 31, "塔城地区", 834700));
            Citys.Add(488, new RegionDivision(488, 31, "阿勒泰地区", 836500));
            Citys.Add(489, new RegionDivision(489, 31, "石河子市", 832000));
            Citys.Add(490, new RegionDivision(490, 31, "阿拉尔市", 843300));
            Citys.Add(491, new RegionDivision(491, 31, "图木舒克市", 844000));
            Citys.Add(492, new RegionDivision(492, 31, "五家渠市", 831300));
            Citys.Add(493, new RegionDivision(493, 32, "台北市", 100052));
            Citys.Add(494, new RegionDivision(494, 32, "高雄市", 100052));
            Citys.Add(495, new RegionDivision(495, 32, "基隆市", 100052));
            Citys.Add(496, new RegionDivision(496, 32, "台中市", 100052));
            Citys.Add(497, new RegionDivision(497, 32, "台南市", 100052));
            Citys.Add(498, new RegionDivision(498, 32, "新竹市", 100052));
            Citys.Add(499, new RegionDivision(499, 32, "嘉义市", 100052));
            Citys.Add(500, new RegionDivision(500, 32, "台北县", 100052));
            Citys.Add(501, new RegionDivision(501, 32, "宜兰县", 0));
            Citys.Add(502, new RegionDivision(502, 32, "桃园县", 56002));
            Citys.Add(503, new RegionDivision(503, 32, "新竹县", 100052));
            Citys.Add(504, new RegionDivision(504, 32, "苗栗县", 0));
            Citys.Add(505, new RegionDivision(505, 32, "台中县", 100052));
            Citys.Add(506, new RegionDivision(506, 32, "彰化县", 0));
            Citys.Add(507, new RegionDivision(507, 32, "南投县", 0));
            Citys.Add(508, new RegionDivision(508, 32, "云林县", 116001));
            Citys.Add(509, new RegionDivision(509, 32, "嘉义县", 100052));
            Citys.Add(510, new RegionDivision(510, 32, "台南县", 100052));
            Citys.Add(511, new RegionDivision(511, 32, "高雄县", 100052));
            Citys.Add(512, new RegionDivision(512, 32, "屏东县", 0));
            Citys.Add(513, new RegionDivision(513, 32, "澎湖县", 0));
            Citys.Add(514, new RegionDivision(514, 32, "台东县", 53400));
            Citys.Add(515, new RegionDivision(515, 32, "花莲县", 253300));
            Citys.Add(516, new RegionDivision(516, 33, "中西区", 999077));
            Citys.Add(517, new RegionDivision(517, 33, "东区", 999077));
            Citys.Add(518, new RegionDivision(518, 33, "九龙城区", 999077));
            Citys.Add(519, new RegionDivision(519, 33, "观塘区", 999077));
            Citys.Add(520, new RegionDivision(520, 33, "南区", 999077));
            Citys.Add(521, new RegionDivision(521, 33, "深水埗区", 999077));
            Citys.Add(522, new RegionDivision(522, 33, "黄大仙区", 999077));
            Citys.Add(523, new RegionDivision(523, 33, "湾仔区", 999077));
            Citys.Add(524, new RegionDivision(524, 33, "油尖旺区", 999077));
            Citys.Add(525, new RegionDivision(525, 33, "离岛区", 999077));
            Citys.Add(526, new RegionDivision(526, 33, "葵青区", 999077));
            Citys.Add(527, new RegionDivision(527, 33, "北区", 999077));
            Citys.Add(528, new RegionDivision(528, 33, "西贡区", 999077));
            Citys.Add(529, new RegionDivision(529, 33, "沙田区", 999077));
            Citys.Add(530, new RegionDivision(530, 33, "屯门区", 999077));
            Citys.Add(531, new RegionDivision(531, 33, "大埔区", 999077));
            Citys.Add(532, new RegionDivision(532, 33, "荃湾区", 999077));
            Citys.Add(533, new RegionDivision(533, 33, "元朗区", 999077));
            Citys.Add(534, new RegionDivision(534, 34, "澳门特别行政区", 999078));
            Citys.Add(5108, new RegionDivision(5108, 25, "怒江州", 673100));
            Citys.Add(5109, new RegionDivision(5109, 25, "普洱市", 665000));
        }
    }
}
