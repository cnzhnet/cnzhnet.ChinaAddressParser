# 中华人民共和国智能地址识别器
提供 C# 及 Kotlin 的纯代码实现（无数据文件）:  
将输入或从身份证扫描所提的地址识别为如下结构：   
```JSON
{
    "province": "省/直辖市",
    "city": "市",
    "area": "区/县",
    "street": "街道.."
}
```
## C#实现版本
提供安整项目解决方案，核心实现在 /cnzhnet.ChinaAddressParser/Parser。示例：    
```C#
AddressInformation address;
using (AddressParser parser = new AddressParser())
{
    address = parser.parse("深圳市南山区高新中一道长园新材料港6栋5楼");
}
```
输出结果如下：   
![](https://github.com/cnzhnet/cnzhnet.ChinaAddressParser/blob/main/docs/csharp-demo.jpg?raw=true)   
    
## Kotlin 实版本    
主要为 android 设备提供脱机地址识别功能，由于jvm函数体代码最大上限为60K故将 areas（即区/县）数据分别在6个文件中进行初始化。若将6个 areas 文件合并则将导致编译错误。效果如下图：    
![](https://github.com/cnzhnet/cnzhnet.ChinaAddressParser/blob/main/docs/kotlin-demo.png?raw=true) 
