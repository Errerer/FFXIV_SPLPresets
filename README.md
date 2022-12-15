# FFXIV_SPLPresets 最终幻想14 SPL相关预设

------

本预设适用于国服6.2炼狱篇零式，预设功能请在下方查看。后续会进行更新，待编辑。

> * 本预设需要使用卫月插件[Splatoon][2]，请灵性下载使用。
> * （用不了SPL就是缘分不到）
> *  国服SPL插件链接：
> *  `https://raw.githubusercontent.com/NightmareXIV/MyDalamudPlugins/main/cn.json`

------

------
 - **请不要在直播软件中显示SPL的绘制，OBS请获取游戏源直播。**

   
 

 - **请不要在游戏内截图中带有SPL绘制的截图**。

   

 - **请不要在任何场合截图炫耀或宣称使用了任何第三方工具/插件。**

   

 - **任何第三方插件都会造成被SE/佛晓封禁游戏账号。**
 
 
------
更多预设请关注Exnter的预设（预设更多更全面）**[点击查看](https://github.com/Exnter/FFXIV_VisualTTS/wiki/P5S~P8S%E7%9B%B8%E5%85%B3)**  
视频教程和科技整合请关注[莫灵喵][1]谢谢！


----------





## **P5S**

  

    预设待补充


----------


## **P6S**

 

 - P6S头顶标志提醒（月环/分摊/大圈）

```
~Lv2~{"Name":"P6S头顶标志提醒（月环/分摊/大圈） ","Group":"P6S","ZoneLockH":[1084],"ElementsL":[{"Name":"去角落1","type":1,"radius":15.0,"overlayTextColor":3355443455,"overlayText":"去角落","refActorComparisonType":7,"refActorVFXPath":"vfx/lockon/eff/m0796_trg_AE_0a1.avfx","refActorVFXMax":10000},{"Name":"去角落2","type":1,"radius":15.0,"overlayTextColor":3355443455,"overlayText":"去角落","refActorComparisonType":7,"refActorVFXPath":"vfx/lockon/eff/m0796_trg_donutA_0a1.avfx","refActorVFXMax":10000},{"Name":"去角落3","type":1,"radius":15.0,"overlayTextColor":3355443449,"overlayText":"去角落","refActorComparisonType":7,"refActorVFXPath":"vfx/lockon/eff/m0796_trg_shartA_0a1.avfx","refActorVFXMax":10000},{"Name":"去场中1","type":1,"radius":6.0,"Donut":8.5,"overlayText":"去场中","refActorComparisonType":7,"refActorVFXPath":"vfx/lockon/eff/m0796_trg_shar_0a1.avfx","refActorVFXMax":10000},{"Name":"去场中2","type":1,"radius":6.0,"overlayText":"去场中","refActorComparisonType":7,"refActorVFXPath":"vfx/lockon/eff/m0796_trg_AEtd_0a1.avfx","refActorVFXMax":10000},{"Name":"去场中3","type":1,"radius":6.0,"overlayText":"去场中","refActorComparisonType":7,"refActorVFXPath":"vfx/lockon/eff/m0796_trg_donu_0a1.avfx","refActorVFXMax":10000},{"Name":"分摊1","type":1,"radius":6.0,"color":2465566191,"overlayText":"分摊","refActorComparisonType":7,"Filled":true,"refActorVFXPath":"vfx/lockon/eff/m0796_trg_shar_0a1.avfx","refActorVFXMax":10000},{"Name":"分摊2","type":1,"radius":6.0,"color":2465566191,"overlayText":"分摊","refActorComparisonType":7,"includeHitbox":true,"Filled":true,"refActorVFXPath":"vfx/lockon/eff/m0796_trg_AEts_0a1.avfx","refActorVFXMax":10000}]}  
```


 - P6S麻将点名提醒
```
         ~Lv2~{"Name":"P6S麻将数字提醒","Group":"","ZoneLockH":[1084],"DCond":5,"ElementsL":  [{"Name":"1","type":1,"radius":0.0,"color":3372220415,"overlayBGColor":1895628028,"overlayTextColor":3355443452,"overlayFScale":1.72,"thicc":0.1,"overlayText":"1","refActorComparisonType":7,"includeOwnHitbox":true,"Filled":true,"refActorVFXPath":"vfx/lockon/eff/m0361trg_a1t.avfx","refActorVFXMax":26000},{"Name":"2","type":1,"radius":0.0,"color":3372220415,"overlayBGColor":1895628028,"overlayTextColor":3355443452,"overlayFScale":1.72,"thicc":0.1,"overlayText":"2","refActorComparisonType":7,"includeOwnHitbox":true,"Filled":true,"refActorVFXPath":"vfx/lockon/eff/m0361trg_a2t.avfx","refActorVFXMax":26000},{"Name":"3","type":1,"radius":0.0,"color":3372220415,"overlayBGColor":1895628028,"overlayTextColor":3355443452,"overlayFScale":1.72,"thicc":0.1,"overlayText":"3","refActorComparisonType":7,"includeOwnHitbox":true,"Filled":true,"refActorVFXPath":"vfx/lockon/eff/m0361trg_a3t.avfx","refActorVFXMax":26000},{"Name":"4","type":1,"radius":0.0,"color":3372220415,"overlayBGColor":1895628028,"overlayTextColor":3355443452,"overlayFScale":1.72,"thicc":0.1,"overlayText":"4","refActorComparisonType":7,"includeOwnHitbox":true,"Filled":true,"refActorVFXPath":"vfx/lockon/eff/m0361trg_a4t.avfx","refActorVFXMax":26000},{"Name":"5","type":1,"radius":0.0,"color":3372220415,"overlayBGColor":1895628028,"overlayTextColor":3355443452,"overlayFScale":1.72,"thicc":0.1,"overlayText":"5","refActorComparisonType":7,"includeOwnHitbox":true,"Filled":true,"refActorVFXPath":"vfx/lockon/eff/m0361trg_a5t.avfx","refActorVFXMax":26000},{"Name":"6","type":1,"radius":0.0,"color":3372220415,"overlayBGColor":1895628028,"overlayTextColor":3355443452,"overlayFScale":1.72,"thicc":0.1,"overlayText":"6","refActorComparisonType":7,"includeOwnHitbox":true,"Filled":true,"refActorVFXPath":"vfx/lockon/eff/m0361trg_a6t.avfx","refActorVFXMax":26000},{"Name":"7","type":1,"radius":0.0,"color":3372220415,"overlayBGColor":1895628028,"overlayTextColor":3355443452,"overlayFScale":1.72,"thicc":0.1,"overlayText":"7","refActorComparisonType":7,"includeOwnHitbox":true,"Filled":true,"refActorVFXPath":"vfx/lockon/eff/m0361trg_a7t.avfx","refActorVFXMax":26000},{"Name":"8","type":1,"radius":0.0,"color":3372220415,"overlayBGColor":1895628028,"overlayTextColor":3355443452,"overlayFScale":1.72,"thicc":0.1,"overlayText":"8","refActorComparisonType":7,"includeOwnHitbox":true,"Filled":true,"refActorVFXPath":"vfx/lockon/eff/m0361trg_a8t.avfx","refActorVFXMax":26000}],"UseTriggers":true,"Triggers":[{"Type":2,"Match":"（11381>30820）"}]} 
```
 

 - P6S魔活细胞倒计时+AOE范围绘制（二选一）
 
  **详细版**
 
    
    
         ~Lv2~{"Name":"P6S魔活细胞倒计时范围（详细倒计时版）","Group":"","ZoneLockH":[1084],"ElementsL":[{"Name":"黑色AOE范围20","type":1,"radius":8.0,"color":3363563506,"overlayText":"20","refActorRequireBuff":true,"refActorBuffId":[3321],"refActorUseBuffTime":true,"refActorBuffTimeMin":19.0,"refActorBuffTimeMax":20.0,"refActorComparisonType":3,"includeRotation":true},{"Name":"黑色AOE范围19","type":1,"radius":8.0,"color":3363563506,"overlayText":"19","refActorRequireBuff":true,"refActorBuffId":[3321],"refActorUseBuffTime":true,"refActorBuffTimeMin":18.0,"refActorBuffTimeMax":19.0,"refActorComparisonType":1,"includeRotation":true},{"Name":"黑色AOE范围18","type":1,"radius":8.0,"color":3363563506,"overlayText":"18","refActorRequireBuff":true,"refActorBuffId":[3321],"refActorUseBuffTime":true,"refActorBuffTimeMin":17.0,"refActorBuffTimeMax":18.0,"refActorComparisonType":1,"includeRotation":true},{"Name":"黑色AOE范围17","type":1,"radius":8.0,"color":3363563506,"overlayText":"17","refActorRequireBuff":true,"refActorBuffId":[3321],"refActorUseBuffTime":true,"refActorBuffTimeMin":16.0,"refActorBuffTimeMax":17.0,"refActorComparisonType":1,"includeRotation":true},{"Name":"黑色AOE范围16","type":1,"radius":8.0,"color":3363563506,"overlayText":"16","refActorRequireBuff":true,"refActorBuffId":[3321],"refActorUseBuffTime":true,"refActorBuffTimeMin":15.0,"refActorBuffTimeMax":16.0,"refActorComparisonType":3,"includeRotation":true},{"Name":"黑色AOE范围15","type":1,"radius":8.0,"color":3363563506,"overlayText":"15","refActorRequireBuff":true,"refActorBuffId":[3321],"refActorUseBuffTime":true,"refActorBuffTimeMin":14.0,"refActorBuffTimeMax":15.0,"refActorComparisonType":3,"includeRotation":true},{"Name":"黑色AOE范围14","type":1,"radius":8.0,"color":3363563506,"overlayText":"14","refActorRequireBuff":true,"refActorBuffId":[3321],"refActorUseBuffTime":true,"refActorBuffTimeMin":13.0,"refActorBuffTimeMax":14.0,"refActorComparisonType":3,"includeRotation":true},{"Name":"黑色AOE范围13","type":1,"radius":8.0,"color":3363563506,"overlayText":"13","refActorRequireBuff":true,"refActorBuffId":[3321],"refActorUseBuffTime":true,"refActorBuffTimeMin":12.0,"refActorBuffTimeMax":13.0,"refActorComparisonType":3,"includeRotation":true},{"Name":"黑色AOE范围12","type":1,"radius":8.0,"color":3363563506,"overlayText":"12","refActorRequireBuff":true,"refActorBuffId":[3321],"refActorUseBuffTime":true,"refActorBuffTimeMin":11.0,"refActorBuffTimeMax":12.0,"refActorComparisonType":3,"includeRotation":true},{"Name":"黑色AOE范围11","type":1,"radius":8.0,"color":3363563506,"overlayText":"11","refActorRequireBuff":true,"refActorBuffId":[3321],"refActorUseBuffTime":true,"refActorBuffTimeMin":10.0,"refActorBuffTimeMax":11.0,"refActorComparisonType":3,"includeRotation":true},{"Name":"黑色AOE范围10","type":1,"radius":8.0,"color":3363563506,"overlayText":"20","refActorRequireBuff":true,"refActorBuffId":[3321],"refActorUseBuffTime":true,"refActorBuffTimeMin":9.0,"refActorBuffTimeMax":10.0,"refActorComparisonType":3,"includeRotation":true},{"Name":"黑色AOE范围9","type":1,"radius":8.0,"color":3363563506,"overlayText":"9","refActorRequireBuff":true,"refActorBuffId":[3321],"refActorUseBuffTime":true,"refActorBuffTimeMin":8.0,"refActorBuffTimeMax":9.0,"refActorComparisonType":3,"includeRotation":true},{"Name":"黑色AOE范围8","type":1,"radius":8.0,"color":3363563506,"overlayText":"8","refActorRequireBuff":true,"refActorBuffId":[3321],"refActorUseBuffTime":true,"refActorBuffTimeMin":7.0,"refActorBuffTimeMax":8.0,"refActorComparisonType":3,"includeRotation":true},{"Name":"黑色AOE范围7","type":1,"radius":8.0,"color":3363563506,"overlayText":"7","refActorRequireBuff":true,"refActorBuffId":[3321],"refActorUseBuffTime":true,"refActorBuffTimeMin":6.0,"refActorBuffTimeMax":7.0,"refActorComparisonType":3,"includeRotation":true},{"Name":"黑色AOE范围6","type":1,"radius":8.0,"color":3363563506,"overlayText":"6","refActorRequireBuff":true,"refActorBuffId":[3321],"refActorUseBuffTime":true,"refActorBuffTimeMin":5.0,"refActorBuffTimeMax":6.0,"refActorComparisonType":3,"includeRotation":true},{"Name":"黑色AOE范围5","type":1,"radius":8.0,"color":3363563506,"overlayText":"5","refActorRequireBuff":true,"refActorBuffId":[3321],"refActorUseBuffTime":true,"refActorBuffTimeMin":4.0,"refActorBuffTimeMax":5.0,"refActorComparisonType":3,"includeRotation":true},{"Name":"黑色AOE范围4","type":1,"radius":8.0,"color":3363563506,"overlayText":"4","refActorRequireBuff":true,"refActorBuffId":[3321],"refActorUseBuffTime":true,"refActorBuffTimeMin":3.0,"refActorBuffTimeMax":4.0,"refActorComparisonType":3,"includeRotation":true},{"Name":"黑色AOE范围3","type":1,"radius":8.0,"color":3363563506,"overlayText":"3","refActorRequireBuff":true,"refActorBuffId":[3321],"refActorUseBuffTime":true,"refActorBuffTimeMin":2.0,"refActorBuffTimeMax":3.0,"refActorComparisonType":3,"includeRotation":true},{"Name":"黑色AOE范围2","type":1,"radius":8.0,"color":3363563506,"overlayText":"2","refActorRequireBuff":true,"refActorBuffId":[3321],"refActorUseBuffTime":true,"refActorBuffTimeMin":1.0,"refActorBuffTimeMax":2.0,"refActorComparisonType":3,"includeRotation":true},{"Name":"黑色AOE范围1","type":1,"radius":8.0,"color":3363563506,"overlayText":"1","refActorRequireBuff":true,"refActorBuffId":[3321],"refActorUseBuffTime":true,"refActorBuffTimeMax":1.0,"refActorComparisonType":3,"includeRotation":true}]}
    
     
     
**简略版**
   ```
   ~Lv2~{"Name":"P6S魔活细胞倒计时+范围（倒计时粗略版）","Group":"","ZoneLockH":[1084],"ElementsL":[{"Name":"魔活细胞20","type":1,"radius":0.0,"color":3363563506,"overlayFScale":1.5,"thicc":0.0,"overlayText":"20","refActorRequireBuff":true,"refActorBuffId":[3321],"refActorUseBuffTime":true,"refActorBuffTimeMin":16.0,"refActorBuffTimeMax":20.0,"refActorComparisonType":3,"includeRotation":true},{"Name":"魔活细胞16","type":1,"radius":0.0,"color":3363563506,"overlayFScale":1.5,"thicc":0.0,"overlayText":"16 ","refActorRequireBuff":true,"refActorBuffId":[3321],"refActorUseBuffTime":true,"refActorBuffTimeMin":12.0,"refActorBuffTimeMax":16.0,"refActorComparisonType":3,"includeRotation":true},{"Name":"魔活细胞12","type":1,"radius":0.0,"color":3363563506,"overlayFScale":1.5,"thicc":0.0,"overlayText":"12","refActorRequireBuff":true,"refActorBuffId":[3321],"refActorUseBuffTime":true,"refActorBuffTimeMin":8.0,"refActorBuffTimeMax":12.0,"refActorComparisonType":3,"includeRotation":true},{"Name":"魔活细胞8","type":1,"radius":0.0,"color":3363563506,"overlayFScale":1.5,"thicc":0.0,"overlayText":"8","refActorRequireBuff":true,"refActorBuffId":[3321],"refActorUseBuffTime":true,"refActorBuffTimeMin":19.0,"refActorBuffTimeMax":20.0,"refActorComparisonType":3,"includeRotation":true},{"Name":"黑色AOE范围","type":1,"radius":8.0,"color":3363563506,"overlayFScale":1.5,"refActorRequireBuff":true,"refActorBuffId":[3321],"refActorBuffTimeMin":16.0,"refActorBuffTimeMax":20.0,"refActorComparisonType":3,"includeRotation":true}]} 
   ```

 - P6S

    待补充
    
    


----------


## **P7S**

 - P7S蛮牛横扫拉线范围/引导顺劈范围
   ```
   ~Lv2~{"Name":"P7S蛮牛横扫拉线范围/引导顺劈范围","Group":"","ZoneLockH":[1086],"ElementsL":[{"Name":"引导牛","type":4,"refY":41.18,"offX":0.12,"offY":0.38,"radius":17.84,"coneAngleMin":-46,"coneAngleMax":48,"color":3369457109,"thicc":0.0,"refActorNPCID":11380,"refActorRequireCast":true,"refActorCastId":[30744],"refActorCastTimeMax":3.1000001,"FillStep":0.763,"refActorComparisonType":4,"includeRotation":true,"onlyVisible":true,"LineAddPlayerHitboxLengthXA":true,"LineAddPlayerHitboxLengthYA":true,"LineAddPlayerHitboxLengthZA":true,"Filled":true},{"Name":"拉线牛","type":4,"refY":41.18,"radius":50.0,"coneAngleMin":-20,"coneAngleMax":20,"color":3355443436,"refActorNPCID":11380,"FillStep":50.0,"refActorComparisonType":4,"includeRotation":true,"onlyVisible":true,"LineAddPlayerHitboxLengthXA":true,"LineAddPlayerHitboxLengthYA":true,"LineAddPlayerHitboxLengthZA":true,"Filled":true,"DistanceSourceX":116.65025,"DistanceSourceY":90.95252,"DistanceSourceZ":0.0099983215}],"Phase":1} 
   ```


 - P7S寻找塔
 ```
 ~Lv2~{"Name":"P7S寻找塔","Group":"","ZoneLockH":[1086],"ElementsL":[{"Name":"塔","type":1,"radius":5.0,"color":1342177535,"overlayText":"塔","refActorNPCID":2013075,"refActorRequireAllBuffs":true,"refActorRequireBuffsInvert":true,"refActorComparisonType":4,"tether":true,"Filled":true,"LimitDistanceInvert":true,"DistanceSourceX":105.63135,"DistanceSourceY":85.99965,"DistanceSourceZ":-1.9073486E-06}]}
 ```

 - P7S运动会找12点(触发器)

  ```
  ~Lv2~{"Name":"P7S运动会找12点(触发器)","Group":"","ZoneLockH":[1086],"DCond":5,"ElementsL":[{"Name":"12点1","type":1,"radius":2.0,"color":1006633207,"overlayText":"12点","refActorNPCNameID":11378,"refActorComparisonType":6,"onlyVisible":true,"tether":true,"Filled":true,"LimitDistance":true,"DistanceSourceX":99.996,"DistanceSourceY":116.3884,"DistanceSourceZ":0.010002136,"DistanceMax":2.0},{"Name":"12点2","type":1,"radius":2.0,"color":1007159536,"overlayText":"12点","refActorNPCNameID":11378,"refActorComparisonType":6,"onlyVisible":true,"tether":true,"Filled":true,"LimitDistance":true,"DistanceSourceX":114.29969,"DistanceSourceY":91.99989,"DistanceSourceZ":0.010000229,"DistanceMax":2.0},{"Name":"12点3","type":1,"radius":2.0,"color":1007159536,"overlayText":"12点","refActorNPCNameID":11378,"refActorComparisonType":6,"onlyVisible":true,"tether":true,"Filled":true,"LimitDistance":true,"DistanceSourceX":85.7224,"DistanceSourceY":91.65758,"DistanceSourceZ":0.010002136,"DistanceMax":2.0}],"UseTriggers":true,"Triggers":[{"Type":2,"Duration":25.0,"Match":"(11374>31312)","ResetOnTChange":false},{"Type":2,"Duration":25.0,"Match":"(11374>31313)","ResetOnTChange":false}]} 
  ```
 

 - P7S  一运拉线安全点 (触发器)
 ```
 ~Lv2~{"Name":"P7S  一运拉线安全点 (触发器)","Group":"","ZoneLockH":[1086],"DCond":5,"ElementsL":[{"Name":"安全点1","type":1,"offX":11.3,"offY":4.22,"offZ":-1.0,"radius":1.0,"thicc":2.5,"refActorNPCID":11374,"refActorComparisonType":4,"includeRotation":true,"onlyVisible":true,"Filled":true},{"Name":"安全点2","type":1,"offX":19.6,"offY":17.66,"offZ":-1.0,"radius":1.0,"thicc":2.5,"refActorNPCID":11374,"refActorComparisonType":4,"includeRotation":true,"onlyVisible":true,"Filled":true},{"Name":"安全点3","type":1,"offX":7.92,"offY":36.56,"offZ":-1.0,"radius":1.0,"thicc":2.5,"refActorNPCID":11374,"refActorComparisonType":4,"includeRotation":true,"onlyVisible":true,"Filled":true},{"Name":"安全点4","type":1,"offX":-8.38,"offY":34.14,"offZ":-1.0,"radius":1.0,"refActorNPCID":11374,"refActorComparisonType":4,"includeRotation":true,"onlyVisible":true,"Filled":true},{"Name":"安全点5","type":1,"offX":-19.1,"offY":17.74,"offZ":-1.0,"radius":1.0,"refActorNPCID":11374,"refActorComparisonType":4,"includeRotation":true,"onlyVisible":true,"Filled":true},{"Name":"安全点6","type":1,"offX":-12.18,"offY":3.82,"offZ":-1.0,"radius":1.0,"refActorNPCID":11374,"refActorComparisonType":4,"includeRotation":true,"onlyVisible":true,"Filled":true}],"UseTriggers":true,"Triggers":[{"Type":2,"TimeBegin":0.5,"Duration":25.0,"Match":"(11374>31311)"}]}
 ```
 


## **P8S 前半**
- P8S  P8S石化射线/蛇毒范围提醒
```
~Lv2~{"Name":"P8S石化射线/蛇毒范围提醒","Group":"","ZoneLockH":[1088],"ElementsL":[{"Name":"石光","type":4,"radius":15.0,"coneAngleMin":-25,"coneAngleMax":20,"color":1693511924,"refActorPlaceholder":["<3>","<2>","<1>","<4>","<5>","<6>","<7>","<8>"],"refActorRequireBuff":true,"refActorBuffId":[3351],"refActorUseBuffTime":true,"refActorBuffTimeMax":6.0,"FillStep":0.01,"refActorComparisonType":5,"refActorType":1,"includeRotation":true,"AdditionalRotation":0.064577185,"Filled":true},{"Name":"蛇毒","type":1,"radius":4.5,"color":839381522,"refActorPlaceholder":["<3>","<2>","<1>","<4>","<5>","<6>","<7>","<8>"],"refActorRequireBuff":true,"refActorBuffId":[3326],"refActorUseBuffTime":true,"refActorBuffTimeMax":6.0,"refActorComparisonType":5,"refActorType":1,"includeRotation":true,"AdditionalRotation":0.064577185,"Filled":true}]}
```
    

## **P8S 后半** 
 - P8S  概念1/2 大圈去哪里放 分摊提醒
 
 **全报**
 ```
 ~Lv2~{"Name":"P8S本体概念标识","Group":"","ZoneLockH":[1088],"ElementsL":[{"Name":"  半成概念：α 早7","type":1,"radius":0.0,"overlayFScale":1.5,"thicc":3.7,"overlayText":"大圈去A（12点）","refActorRequireBuff":true,"refActorBuffId":[3330],"refActorUseBuffTime":true,"refActorBuffTimeMax":7.0,"refActorComparisonType":1},{"Name":"  半成概念：β 早7","type":1,"radius":0.0,"overlayFScale":1.5,"thicc":3.7,"overlayText":"大圈去B（3点）","refActorRequireBuff":true,"refActorBuffId":[3331],"refActorUseBuffTime":true,"refActorBuffTimeMax":7.0,"refActorComparisonType":1},{"Name":"  半成概念：γ 早7","type":1,"radius":0.0,"overlayFScale":1.5,"thicc":3.7,"overlayText":"大圈去C（6点）","refActorRequireBuff":true,"refActorBuffId":[3332],"refActorUseBuffTime":true,"refActorBuffTimeMax":7.0,"refActorComparisonType":1},{"Name":"单相排斥概念","type":1,"radius":0.0,"overlayFScale":1.5,"thicc":0.0,"overlayText":"单人大圈","refActorRequireBuff":true,"refActorBuffId":[3345],"refActorComparisonType":1},{"Name":"多相排斥概念","type":1,"radius":0.0,"overlayFScale":1.5,"thicc":0.0,"overlayText":"三人分摊","refActorRequireBuff":true,"refActorBuffId":[3347],"refActorComparisonType":1},{"Name":"双相排斥概念","type":1,"radius":0.0,"overlayFScale":1.5,"thicc":0.0,"overlayText":"二人分摊","refActorRequireBuff":true,"refActorBuffId":[3346],"refActorComparisonType":1}]}
 ```
 ***只报自己***
 ```
 ~Lv2~{"Name":"P8S本体概念标识","Group":"","ZoneLockH":[1088],"ElementsL":[{"Name":"  半成概念：α 早7","type":1,"radius":0.0,"overlayFScale":1.5,"thicc":3.7,"overlayText":"大圈去A（12点）","refActorRequireBuff":true,"refActorBuffId":[3330],"refActorUseBuffTime":true,"refActorBuffTimeMax":7.0,"refActorComparisonType":1,"refActorType":1},{"Name":"  半成概念：β 早7","type":1,"radius":0.0,"overlayFScale":1.5,"thicc":3.7,"overlayText":"大圈去B（3点）","refActorRequireBuff":true,"refActorBuffId":[3331],"refActorUseBuffTime":true,"refActorBuffTimeMax":7.0,"refActorComparisonType":1,"refActorType":1},{"Name":"  半成概念：γ 早7","type":1,"radius":0.0,"overlayFScale":1.5,"thicc":3.7,"overlayText":"大圈去C（6点）","refActorRequireBuff":true,"refActorBuffId":[3332],"refActorUseBuffTime":true,"refActorBuffTimeMax":7.0,"refActorComparisonType":1,"refActorType":1},{"Name":"单相排斥概念","type":1,"radius":0.0,"overlayFScale":1.5,"thicc":0.0,"overlayText":"单人大圈","refActorRequireBuff":true,"refActorBuffId":[3345],"refActorComparisonType":1,"refActorType":1},{"Name":"多相排斥概念","type":1,"radius":0.0,"overlayFScale":1.5,"thicc":0.0,"overlayText":"三人分摊","refActorRequireBuff":true,"refActorBuffId":[3347],"refActorComparisonType":1,"refActorType":1},{"Name":"双相排斥概念","type":1,"radius":0.0,"overlayFScale":1.5,"thicc":0.0,"overlayText":"二人分摊","refActorRequireBuff":true,"refActorBuffId":[3346],"refActorComparisonType":1,"refActorType":1}]}
 ```
 
  - P8S  塔提醒去合成（触发器）
 
 **全报**
   ```
   ~Lv2~{"Name":"雷塔提醒buff去合成","Group":"","ZoneLockH":[1088],"DCond":5,"ElementsL":[{"Name":"雷β","type":1,"radius":1.0,"color":3357995985,"overlayFScale":1.5,"thicc":1.0,"overlayText":"去合成","refActorPlaceholder":["<1>","<2>","<3>","<4>","<5>","<6>","<7>","<8>"],"refActorRequireBuff":true,"refActorBuffId":[3334],"refActorComparisonType":5,"onlyVisible":true,"tether":true,"Filled":true},{"Name":"雷γ","type":1,"radius":1.0,"color":3356339025,"overlayFScale":1.5,"thicc":1.0,"overlayText":"去合成","refActorPlaceholder":["<1>","<2>","<3>","<4>","<5>","<6>","<7>","<8>"],"refActorRequireBuff":true,"refActorBuffId":[3335],"refActorComparisonType":5,"onlyVisible":true,"tether":true,"Filled":true}],"UseTriggers":true,"Triggers":[{"Type":2,"Duration":10.0,"Match":"26, 1, 2"},{"Type":2,"Duration":10.0,"Match":"27, 1, 2"},{"Type":2,"Duration":10.0,"Match":"28, 1, 2"},{"Type":2,"Duration":10.0,"Match":"29, 1, 2"},{"Type":2,"Duration":10.0,"Match":"30, 1, 2"},{"Type":2,"Duration":10.0,"Match":"31, 1, 2"},{"Type":2,"Duration":10.0,"Match":"32, 1, 2"},{"Type":2,"Duration":10.0,"Match":"33, 1, 2"},{"Type":2,"Duration":10.0,"Match":"34, 1, 2"},{"Type":2,"Duration":10.0,"Match":"35, 1, 2"}]}
   ```
   ```
   ~Lv2~{"Name":"水塔提醒buff去合成","Group":"","ZoneLockH":[1088],"DCond":5,"ElementsL":[{"Name":"水β","type":1,"radius":1.0,"color":3357995985,"overlayFScale":1.5,"thicc":1.0,"overlayText":"去合成","refActorPlaceholder":["<1>","<2>","<3>","<4>","<5>","<6>","<7>","<8>"],"refActorRequireBuff":true,"refActorBuffId":[3335],"refActorComparisonType":5,"onlyVisible":true,"tether":true,"Filled":true},{"Name":"水α","type":1,"radius":1.0,"overlayFScale":1.5,"thicc":1.0,"overlayText":"去合成","refActorPlaceholder":["<1>","<2>","<3>","<4>","<5>","<6>","<7>","<8>"],"refActorRequireBuff":true,"refActorBuffId":[3333],"refActorComparisonType":5,"onlyVisible":true,"tether":true,"Filled":true},{"Name":"雷","type":1,"Enabled":false,"radius":0.0,"overlayFScale":1.5,"thicc":0.0,"overlayText":"去合成","refActorPlaceholder":["<1>","<2>","<3>","<4>","<5>","<6>","<7>","<8>"],"refActorRequireBuff":true,"refActorBuffId":[3333,3335],"refActorComparisonType":5,"onlyVisible":true}],"UseTriggers":true,"Triggers":[{"Type":2,"Duration":10.0,"Match":"36, 1, 2"},{"Type":2,"Duration":10.0,"Match":"37, 1, 2"},{"Type":2,"Duration":10.0,"Match":"38, 1, 2"},{"Type":2,"Duration":10.0,"Match":"39, 1, 2"},{"Type":2,"Duration":10.0,"Match":"40, 1, 2"},{"Type":2,"Duration":10.0,"Match":"41, 1, 2"},{"Type":2,"Duration":10.0,"Match":"42, 1, 2"},{"Type":2,"Duration":10.0,"Match":"43 1, 2"},{"Type":2,"Duration":10.0,"Match":"44, 1, 2"},{"Type":2,"Duration":10.0,"Match":"45, 1, 2"}]}
   ```
   ```
   ~Lv2~{"Name":"风塔提醒buff去合成","Group":"","ZoneLockH":[1088],"DCond":5,"ElementsL":[{"Name":"风α","type":1,"radius":1.0,"overlayFScale":1.5,"thicc":1.0,"overlayText":"去合成 ","refActorPlaceholder":["<1>","<2>","<3>","<4>","<5>","<6>","<7>","<8>"],"refActorRequireBuff":true,"refActorBuffId":[3333],"refActorComparisonType":5,"onlyVisible":true,"tether":true,"Filled":true},{"Name":"风β","type":1,"radius":1.0,"color":3357995985,"overlayFScale":1.5,"thicc":1.0,"overlayText":"去合成","refActorPlaceholder":["<1>","<2>","<3>","<4>","<5>","<6>","<7>","<8>"],"refActorRequireBuff":true,"refActorBuffId":[3334],"refActorComparisonType":5,"onlyVisible":true,"tether":true,"Filled":true}],"UseTriggers":true,"Triggers":[{"Type":2,"Duration":10.0,"Match":"50, 1, 2"},{"Type":2,"Duration":10.0,"Match":"51, 1, 2"},{"Type":2,"Duration":10.0,"Match":"52, 1, 2"},{"Type":2,"Duration":10.0,"Match":"53, 1, 2"},{"Type":2,"Duration":10.0,"Match":"54, 1, 2"},{"Type":2,"Duration":10.0,"Match":"55, 1, 2"},{"Type":2,"Duration":10.0,"Match":"49, 1, 2"},{"Type":2,"Duration":10.0,"Match":"48, 1, 2"},{"Type":2,"Duration":10.0,"Match":"47, 1, 2"},{"Type":2,"Duration":10.0,"Match":"46, 1, 2"}]}
   ```
   
***只报自己***
```
~Lv2~{"Name":"风塔提醒buff去合成","Group":"","ZoneLockH":[1088],"DCond":5,"ElementsL":[{"Name":"风α","type":1,"radius":0.0,"overlayFScale":1.5,"thicc":0.0,"overlayText":"去合成 ","refActorPlaceholder":["<1>","<2>","<3>","<4>","<5>","<6>","<7>","<8>"],"refActorRequireBuff":true,"refActorBuffId":[3333],"refActorComparisonType":5,"refActorType":1,"onlyVisible":true,"tether":true},{"Name":"风β","type":1,"radius":0.0,"color":3357995985,"overlayFScale":1.5,"thicc":0.0,"overlayText":"去合成","refActorPlaceholder":["<1>","<2>","<3>","<4>","<5>","<6>","<7>","<8>"],"refActorRequireBuff":true,"refActorBuffId":[3334],"refActorComparisonType":5,"refActorType":1,"onlyVisible":true,"tether":true}],"UseTriggers":true,"Triggers":[{"Type":2,"Duration":10.0,"Match":"50, 1, 2"},{"Type":2,"Duration":10.0,"Match":"51, 1, 2"},{"Type":2,"Duration":10.0,"Match":"52, 1, 2"},{"Type":2,"Duration":10.0,"Match":"53, 1, 2"},{"Type":2,"Duration":10.0,"Match":"54, 1, 2"},{"Type":2,"Duration":10.0,"Match":"55, 1, 2"},{"Type":2,"Duration":10.0,"Match":"49, 1, 2"},{"Type":2,"Duration":10.0,"Match":"48, 1, 2"},{"Type":2,"Duration":10.0,"Match":"47, 1, 2"},{"Type":2,"Duration":10.0,"Match":"46, 1, 2"}]}
```
```
~Lv2~{"Name":"风塔提醒buff去合成","Group":"","ZoneLockH":[1088],"DCond":5,"ElementsL":[{"Name":"风α","type":1,"radius":0.0,"overlayFScale":1.5,"thicc":0.0,"overlayText":"去合成 ","refActorPlaceholder":["<1>","<2>","<3>","<4>","<5>","<6>","<7>","<8>"],"refActorRequireBuff":true,"refActorBuffId":[3333],"refActorComparisonType":5,"refActorType":1,"onlyVisible":true,"tether":true},{"Name":"风β","type":1,"radius":0.0,"color":3357995985,"overlayFScale":1.5,"thicc":0.0,"overlayText":"去合成","refActorPlaceholder":["<1>","<2>","<3>","<4>","<5>","<6>","<7>","<8>"],"refActorRequireBuff":true,"refActorBuffId":[3334],"refActorComparisonType":5,"refActorType":1,"onlyVisible":true,"tether":true}],"UseTriggers":true,"Triggers":[{"Type":2,"Duration":10.0,"Match":"50, 1, 2"},{"Type":2,"Duration":10.0,"Match":"51, 1, 2"},{"Type":2,"Duration":10.0,"Match":"52, 1, 2"},{"Type":2,"Duration":10.0,"Match":"53, 1, 2"},{"Type":2,"Duration":10.0,"Match":"54, 1, 2"},{"Type":2,"Duration":10.0,"Match":"55, 1, 2"},{"Type":2,"Duration":10.0,"Match":"49, 1, 2"},{"Type":2,"Duration":10.0,"Match":"48, 1, 2"},{"Type":2,"Duration":10.0,"Match":"47, 1, 2"},{"Type":2,"Duration":10.0,"Match":"46, 1, 2"}]}
```
```
~Lv2~{"Name":"雷塔提醒buff去合成","Group":"","ZoneLockH":[1088],"DCond":5,"ElementsL":[{"Name":"雷β","type":1,"radius":0.0,"color":3357995985,"overlayFScale":1.5,"thicc":0.0,"overlayText":"去合成","refActorPlaceholder":["<1>","<2>","<3>","<4>","<5>","<6>","<7>","<8>"],"refActorRequireBuff":true,"refActorBuffId":[3334],"refActorComparisonType":5,"refActorType":1,"onlyVisible":true,"tether":true},{"Name":"雷γ","type":1,"radius":0.0,"color":3356339025,"overlayFScale":1.5,"thicc":0.0,"overlayText":"去合成","refActorPlaceholder":["<1>","<2>","<3>","<4>","<5>","<6>","<7>","<8>"],"refActorRequireBuff":true,"refActorBuffId":[3335],"refActorComparisonType":5,"refActorType":1,"onlyVisible":true,"tether":true}],"UseTriggers":true,"Triggers":[{"Type":2,"Duration":10.0,"Match":"26, 1, 2"},{"Type":2,"Duration":10.0,"Match":"27, 1, 2"},{"Type":2,"Duration":10.0,"Match":"28, 1, 2"},{"Type":2,"Duration":10.0,"Match":"29, 1, 2"},{"Type":2,"Duration":10.0,"Match":"30, 1, 2"},{"Type":2,"Duration":10.0,"Match":"31, 1, 2"},{"Type":2,"Duration":10.0,"Match":"32, 1, 2"},{"Type":2,"Duration":10.0,"Match":"33, 1, 2"},{"Type":2,"Duration":10.0,"Match":"34, 1, 2"},{"Type":2,"Duration":10.0,"Match":"35, 1, 2"}]}
```
 
 

    待补充


  [1]: https://space.bilibili.com/220756407
  [2]:https://github.com/NightmareXIV/Splatoon
