# OmniSNG

OmniSNG is a multifunctional & fully-automated Digital Satellite News Gathering (DSNG) signal receiving system.

OmniSNG 是一套多功能全自动数字卫星新闻采集信号(DSNG)地面接收系统。


![OmniSNG preview](https://thumbs2.imgbox.com/66/cb/vQQrMFzN_t.png)


# Software features / 软件功能

- Dedicated UI and workflow design for DSNG signal reception.

- Unfiltered complete carrier data.

- Multi-tuner support.

- Multi-channel HTTP, TCP, file output.

- Scaled BER, SNR, service name display.

- Ultra-fast BISS (DVB-CSA) decryption with FFDesca.

- Blind scan.

- API control.

- Adapter and satellite controller configuration files.

- Smart dispatch controller for fully-automated DSNG signal capture.

- English language support (partial).

---

- 专为DSNG信号接收设计的操作界面和工作流程。

- 未经删改的完整载波数据。

- 多路调谐器支持。

- 多路HTTP、TCP、文件输出支持。

- 易读BER比例、SNR、服务名称显示。

- 使用FFDesca高速解密BISS(DVB-CSA)加密方式。

- 盲扫。

- API控制。

- 多适配器和卫星控制器配置文件。

- 智慧调度控制器，全时段DSNG信号自动捕获。

- 简体中文语言支持。


# System requirements / 系统要求

Applicable for Windows 7 and above operating systems.

适用于Windows 7及以上操作系统。


# Receiving device / 接收装置

Unless you know exactly what you are buying, then follow us.

Whether a satellite receiving card can bring you desired effect, the most important thing is not the manufacturer or the model of the card, but its demodulation chip. I'm sorry but there is no perfect demodulation chip in the world. You can only choose the chip that benefits for you needs.

To make a long story short, the Montage M88RS6060 model is the most suitable "tuner + demod" combo chip for DSNG signal reception that we have come across so far.

It can provide you with:

- Very low SNR threshold & stable signal reception of carriers w/symbol rates higher than 4000 ksps.

- Ultra-high-speed blind scan (20 secs per 500 MHz range).

- Support for various modulation methods of DVB-S2 and DVB-S2X.

These seemingly basic features are however not available in many other competing products on the market. Therefore, if you are targeting DSNG signal reception, there's no need to waste a single cent of dollar on other competing products.

Nevertheless, this chip has defects. It is not stable for some rarely used DVB-S2/S2X modulation types, DVB-S1 low signal conditions, and symbol rates less than 4000 ksps. Therefore, if most of the DSNG you want to receive belongs to the above conditions, please do not consider this chip.

To save your time, we recommend that you directly purchase the cost-effective TBS6904SE tuner card that utilizes Montage M88RS6060 combo chips.

https://shop.tbsdtv.com/tbs6904se-dvbs2x-quad-tuner-pcie-card-p-338.html

In addition,

- TBS6904 is not TBS6904SE. Don't mess them up.

- Do not attempt to buy a receiving card with the same demodulator chip but using the USB interface. Satellite receiving products using the USB protocol stack are not stable.

- We have nothing to do with Montage or Turbosight.

Good luck, have fun.

---

除非您完全清楚自己在买什么，否则请听我说。

一款卫星接收卡是否能够带来理想的效果，最重要的并不是制造商或者产品型号，而是其内置的解调芯片。非常遗憾，但是世界上并没有完美的解调芯片。只有根据您的具体需求来挑选擅长于您所需工作的芯片。

长话短说，澜至电子科技M88RS6060型号集成化调谐芯片是我们目前已知最适合于DSNG信号接收的产品。它能够为您提供：

- 对高于4000 ksps符号率的载波，极低门限的稳定接收。

- 高速盲扫(每20秒可完成扫描一个500 MHz的区间)。

- 对DVB-S2和DVB-S2X标准中各种调制方式的支持。

然而，这些看似最基本的特性是市面上很多其他竞品不存在的。因此，如果是为了DSNG信号接收，您完全不需要再浪费任何一分钱在其他的竞品上。

当然，这款调谐芯片并不是没有任何缺陷。它对于一些特殊的DVB-S2/S2X调制方式、DVB-S1低信号的情况，以及接收符号率小于4000 ksps的情况并不稳定。因此如果您要接收的多数DSNG属于上述情况，请不要考虑这款芯片。

为了节省您的时间，我们推荐您直接购买性价比超高的型号为TBS6904SE的接收卡即可（它采用了澜至电子科技M88RS6060型号解调芯片）。

https://item.taobao.com/item.htm?id=639106044108

另外，

- TBS6904并不是TBS6904SE，不要将它们弄混。

- 不要尝试购买相同型号解调芯片但是采用USB接口的接收卡。采用USB协议栈的卫星接收产品并不稳定。

- 我们不是成都澜至电子科技或者深圳特博赛科技的托。

祝您好运。


# Open source / 开源代码

OmniSNG uses the following open source or third-party components, whose source code or binaries are available from their respective project pages.

OmniSNG 使用以下开源或第三方组件，其源代码或运行库可通过对应的项目页面获取。

---

StreamReaderEx for BDA Tuners (by CrazyCat): https://sourceforge.net/projects/crazyscan

FFDecsa (by Altx): https://www.altx.ro/projects/ffdecsa

libdvbpsi: https://www.videolan.org/developers/libdvbpsi.html

Fast Reverse Proxy: https://github.com/fatedier/frp

---

Many thanks.

非常感谢。


# Changelog / 更新日志

**8.3.1 (2024/07/13)**

1.修复解扰本地文件尾部不完整的问题。

---

**8.3.0 (2024/05/08)**

1.支持使用"?log"参数请求API查看日志。

2.增加控制器自动重启搜索适配器时允许忽略任务进行情况的配置文件参数。

---

**8.2.0 (2024/04/25)**

1.控制器界面添加计时器，指示上次搜索数据更新时间间隔。

2.控制器支持无任务时自动重启搜索适配器，预防搜索适配器在运行一段时间后驱动层崩溃，导致无法正常进行任务调度的情况。

若要使用此功能，请在控制器配置文件中里添加"SearchRestart=30"。其中"30"表示每三十分钟自动重新启动搜索适配器。

3.对控制器的搜索结果更新机制进行了调整。

4.对HTTP服务的响应头进行了优化。

5.增加了解扰界面粘贴CSA Rainbow Table Tool生成的文本后自动识别密钥的功能。

6.调整了一个StreamReader的接口调用方式。

---

**8.1.0 (2024/03/14)**

1.控制器界面增加排除转发器时，同时删除已录制的文件的功能。

2.通过API下发指令时，增加了布尔值快速缩写办法。例如"Standby=True"可以缩写为"Standby"，而"Standby=False"可以缩写为"!Standby"。

3.少量程序优化。

---

**8.0.1 (2024/03/08)**

1.OmniSNG 8.0针对控制器和远程协助场景进行了改善，并引入了主、从控制器的概念。

在卫星控制器配置文件中添加"Slave=1"则表示该配置器为从控制器，并且该参数必须在配置文件中靠前添加。

2.当所有适配器在控制器的管理下时，有时我们会希望能够将某个调谐器预留给固定的载波，即使信号尚未上星。

在这种情况下，现在可以使用Standby模式。通过API发送进入Standby模式的指令为"?Standby=1"。

如果希望在转发器锁定时直接进入该模式，则可以直接在转发器输入框结尾添加问号，例如"4004H7200?"。

如此，在所有适配器在受到控制器统一管理的同时，还可以将适配器接口预留给某个特定载波信号。

如需解除Standby模式，可以通过停止任务，或API发送解除指令"?Standby=0"。

处于Standby模式的适配器，在控制器中的状态会一直显示为"Started"，故控制器不会主动对其下达指令。

3.主控制器往往在地面站所有者本地工作，而从控制器由远程协助者进行协助。

由于OmniSNG并不支持控制器之间的相互通信，因此当从从控制器发现需要排除的信号时，无法有效通知主控制器。

OmniSNG 8.0支持通过API向适配器添加排除标记"?Exclude=1"。

当接口被标记为“排除”后，主控制器发现该标记即会向自身添加临时排除。

4.除此之外，OmniSNG 8.0还对控制器联网策略进行了调整。

现在支持使用HTTP代理进行适配器连接，可在控制器配置文件中填写例如 "Proxy=http://11.22.33.44:5678" 的代理服务器地址。

我们也对HTTP连接功能进行了相关优化，可以使公网远程连接更加畅通，并减少本地连接失败的情况。

5.在控制器的排除频率输入框中按下回车，现已更改为临时排除频率，并且如果输入待排除的服务名，也会自动添加为排除服务。

6.增加英语语言支持。
