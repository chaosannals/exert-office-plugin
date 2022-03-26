# Excel VSTO

## 使用 WinForm 自定义 UI

需要手动找到并浏览添加程序集 Microsoft.Office.Tools.Excel.v4.0.Utilities.dll 不然没有名字控件 Microsoft.Office.Tools.Excel.Controls

例如，通过其他 dll 找到路径，示例本机路径：
C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\IDE\ReferenceAssemblies\v4.0\Microsoft.Office.Tools.Excel.v4.0.Utilities.dll

注：不同名字空间里面出现同名类和类名相似属性名。混合动态类型和类型转换，所以使用的时候要注意找到正确的东西。

Microsoft.Office.Interop.Excel 名字空间下的 Workbook， Worksheet，ListObject 等实例
都可以通过 Globals.Factory.GetVstoObject
得到对应 Microsoft.Office.Tools.Excel 名字空间下的实例。

## 使用 WPF

Office 是 WinForm 软件，插件默认只能加入 WinForm 控件。
使用 WPF 是通过 System.Windows.Forms.Integration.ElementHost 这个类，在 WinForm 框出一个 Wpf 的用户控件。
这种方式普通 WinForm 也可以使用，不过有一定的弊端。

注：需要手动引入 WindowsFormsIntegration.dll 程序集。
可能路径：
- C:\Program Files\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0\WindowsFormsIntegration.dll
- C:\Program Files\Reference Assemblies\Microsoft\Framework\.NETFramework\v3.0\WindowsFormsIntegration.dll

## 功能区

功能区 tab 的（Name） ControlId 必须是不会和其他的功能区重复的，不然会覆盖。
注：默认创建的那个 tab 不能修改 ControlId 导致多个项目一起操作了这个 tab，建议删除后自己添加一个。

注：不知道是不是因为缓存，有时候还是会把组合并，但是后来又不会。

## 任务面板

需要根据 打开的 Workbook 管理控件。

注：任务面板要根据 Workbook 添加。如果只是根据插件添加，只会有一个。
