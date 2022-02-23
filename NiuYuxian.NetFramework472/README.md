nuget pack -prop Configuration=Release

注意 nuget 版本。
5.3 之后会出现warning
或者
<NoWarn>NU5128</NoWarn>

Glob Pattern 输入 *

nuget setApiKey ***
nuget push ClassLibrary1.1.0.0.nupkg -Source https://api.nuget.org/v3/index.json

遇到问题：在执行 push 操作时，发现出现如下 403 错误，注意是名称重复...