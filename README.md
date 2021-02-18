# Walle.GitHubCleaner
用于删除未使用或打算放弃使用的仓库。

## Get Started.

1. 在 https://github.com/settings/tokens 或 https://github.com/settings/tokens/new 获取您的```个人Token（PAT）```。
2. 如下图，在项目目录下使用 ```dotnet run ```命令执行构建并启动应用程序。 
3. 输入```PAT```后回车。软件将列出您作为owner的所有仓库。
4. 输入仓库号码，并需要确认，以删除指定仓库。

```ssh
misaya@Misaya-MacBookAir Walle.GitHubCleaner % dotnet run
Put in your PAT:
f3075a510e81622d02e035e8a0d3bcbe96123456
Listing Repositories...
	339920689	walle-work/Walle.GitHubCleaner(2021-02-18 11:05)
	298442020	walle-work/Walle.Tools.MonGhost(2020-09-25 10:01)
	292267447	walle-work/Walle.Components(2020-09-02 19:45)
	283121825	walle-work/Walle.Blog(2020-07-28 14:28)
	257159290	walle-work/Walle.IntentFuzzer(2020-04-20 11:16)
	256919108	walle-work/Walle.Device.Management.WebUI(2020-04-19 13:08)
	256128160	walle-work/Walle.SecureDevelopmentLifecycle.Wiki(2020-04-16 14:25)
	256118565	walle-work/Walle.Device.Management(2020-04-16 13:32)
	132722301	walle-work/Walle.Excel.Extension(2018-05-09 15:58)
	131258934	walle-work/Walle.CasePlus(2018-04-27 15:04)
	131258820	walle-work/Walle.Documents(2018-04-27 15:03)
	131258735	walle-work/Walle.Configuration(2018-04-27 15:02)
	131258488	walle-work/Walle.DevOps(2018-04-27 15:00)
	131258332	walle-work/Walle.Mocker(2018-04-27 14:58)
	131258034	walle-work/Walle.Watching(2018-04-27 14:56)
	131257291	walle-work/Walle.SSO(2018-04-27 14:48)
	113567632	walle-work/Walle.WorkFlowEngine(2017-12-08 19:30)
	48826917	misaya/MyMVC(2015-12-31 09:29)
Input target repository id to delete:257159290
Fetching detail..
	Walle.IntentFuzzer
	walle-work/Walle.IntentFuzzer
	https://github.com/walle-work/Walle.IntentFuzzer
	git@github.com:walle-work/Walle.IntentFuzzer.git
	A Tool to fuzz Intent on Android
Delete Walle.IntentFuzzer ?[Y/n]
n
```
