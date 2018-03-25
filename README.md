# 简答题和井字棋的介绍
### 1. 解释游戏对象(GameObjects)和资源(Assets)的区别与联系。
GameObjects: 游戏对象是Unity中人物，道具和风景的基本单位，它们本身并不实现自己，但是它们充当组件的
容器，开发人员可以将组件加入到游戏对象中，从而实现你想要的功能。可以把游戏组件想象成积木，你需要什么
样形状的积木你就加上去，最后拼出来的就是游戏对象了，游戏对象也可以为空
Assets: asset指的是资源，像游戏中用到的模型啊声音啊动画啊以及场景都是asset，甚至连脚本也包括在资源
的范围里，可以将资源看做一个库，游戏中用到的各种数据都放在这个库中
游戏对象包括在游戏资源中，因为游戏对象的产生离不开游戏资源的支持，而生成的游戏对象又可以反过来作为
游戏资源，成为制作新的游戏对象的资源。

### 2.下载几个游戏案例，分别总结资源、对象组织的结构（指资源的目录组织结构与游戏对象树的层次结构）
下载的案例：Tank! Tutorial，Space Shooter
因为这些案例的目录组织和数的结构都是差不多的，所以我以坦克大战为例

![](https://github.com/flashowner/first3DHomework/blob/master/%E5%9B%BE%E7%89%871.PNG)
<br>
这是坦克大战的目录，从中可以看出资源的文件夹下有很多子文件夹，同一类型的资源放在同一个文件夹下，比如
说所有的脚本文件都放在Scripts这个文件夹下，所有的模型都放在Prefabs这个文件夹下。然后在对应的类下，
又可以有一些分支，所有的这些文件构成了资源

![](https://github.com/flashowner/first3DHomework/blob/master/%E5%9B%BE%E7%89%872.PNG)<br>
这是坦克大战游戏对象树的层次目录，可以看出游戏对象既可以由它自己组成，也可以由游戏对象及它的子树构成
，树形的层次结构很好的显示了不同游戏对象之间的关系。如果一个游戏对象受另一个游戏对象的控制，那么这个
游戏对象应该是另一个游戏对象的子对象。

### 3. 编写一个代码，使用debug语句来验证MonoBehaviou 基本行为或事件触发的条件
代码：<br>
![](https://github.com/flashowner/first3DHomework/blob/master/%E5%9B%BE%E7%89%873.PNG)
<br>
结果：<br>
![](https://github.com/flashowner/first3DHomework/blob/master/%E5%9B%BE%E7%89%874.PNG)
<br>
从结果中可以看出，Awake行为是在游戏对象被唤醒时就调用的，Start行为是游戏对象开始执行行为时调用
的，可以看作是初始化，Update是每一帧画面都调用，LateUpdate是在所有Update都执行完后才调用，Fix
Update是最后才调用的，因为FixedUpdate一般都是用来控制物体移动的和Rigidbody有关的行为。<br>
代码：<br>
![](https://github.com/flashowner/first3DHomework/blob/master/%E5%9B%BE%E7%89%875.PNG)
<br>
结果：<br>
