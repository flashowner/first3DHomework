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
![](https://github.com/flashowner/first3DHomework/blob/master/%E5%9B%BE%E7%89%876.PNG)
<br>
从结果上看，OnEnable事件是在游戏对象创建的时候调用的，OnDisable事件是在游戏对象被销毁时调用的，
而OnGUI是在游戏运行的每一帧调用的

### 4. 查找脚本手册，了解 GameObject，Transform，Component 对象
* 分别翻译官方对三个对象的描述（Description）
游戏对象(GameObject)是在Unity中用来表示人物，道具和风景的对象，它们并没有太多的自我实现但是它们
作为部件的容器可以实现真正的功能。
(Transform)变换组件决定的是在场景中每一个对象的位置，旋转和大小。每一个游戏对象都有一个变换。
(Component)组件是一切附加到物体的基类
* 描述下图中 table 对象（实体）的属性、table 的 Transform 的属性、 table 的部件
table是一个3D部件是一个立方体，它的名字叫table，它的Transform属性有三个特性position,rotation,
scale，分别表示它在世界地图的位置，旋转和大小，可以看出table的位置是(0,0,0)，它并没有旋转，而且
从大小可以看出它是一个长宽高都是1的立方体。table的部件有Transform:游戏对象的转换，Mesh Henderer
:游戏对象的渲染，Mateirals:游戏对象的材质，Box Collider游戏对象的材质
