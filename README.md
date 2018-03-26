# 简答题和井字棋的介绍
### 1. 解释游戏对象(GameObjects)和资源(Assets)的区别与联系。
GameObjects: 游戏对象是Unity中人物，道具和风景的基本单位，它们本身并不实现自己，但是它们充当组件的<br>
容器，开发人员可以将组件加入到游戏对象中，从而实现你想要的功能。可以把游戏组件想象成积木，你需要什么<br>
样形状的积木你就加上去，最后拼出来的就是游戏对象了，游戏对象也可以为空<br>
Assets: asset指的是资源，像游戏中用到的模型啊声音啊动画啊以及场景都是asset，甚至连脚本也包括在资源<br>
的范围里，可以将资源看做一个库，游戏中用到的各种数据都放在这个库中<br>
游戏对象包括在游戏资源中，因为游戏对象的产生离不开游戏资源的支持，而生成的游戏对象又可以反过来作为<br>
游戏资源，成为制作新的游戏对象的资源。<br>

### 2.下载几个游戏案例，分别总结资源、对象组织的结构（指资源的目录组织结构与游戏对象树的层次结构）
下载的案例：Tank! Tutorial，Space Shooter<br>
因为这些案例的目录组织和数的结构都是差不多的，所以我以坦克大战为例<br>

![](https://github.com/flashowner/first3DHomework/blob/master/%E5%9B%BE%E7%89%871.PNG)
<br>
这是坦克大战的目录，从中可以看出资源的文件夹下有很多子文件夹，同一类型的资源放在同一个文件夹下，比如<br>
说所有的脚本文件都放在Scripts这个文件夹下，所有的模型都放在Prefabs这个文件夹下。然后在对应的类下，<br>
又可以有一些分支，所有的这些文件构成了资源<br>

![](https://github.com/flashowner/first3DHomework/blob/master/%E5%9B%BE%E7%89%872.PNG)<br>
这是坦克大战游戏对象树的层次目录，可以看出游戏对象既可以由它自己组成，也可以由游戏对象及它的子树构成<br>
，树形的层次结构很好的显示了不同游戏对象之间的关系。如果一个游戏对象受另一个游戏对象的控制，那么这个<br>
游戏对象应该是另一个游戏对象的子对象。<br>

### 3. 编写一个代码，使用debug语句来验证MonoBehaviou 基本行为或事件触发的条件
代码：<br>
![](https://github.com/flashowner/first3DHomework/blob/master/%E5%9B%BE%E7%89%873.PNG)
<br>
结果：<br>
![](https://github.com/flashowner/first3DHomework/blob/master/%E5%9B%BE%E7%89%874.PNG)
<br>
从结果中可以看出，Awake行为是在游戏对象被唤醒时就调用的，Start行为是游戏对象开始执行行为时调用<br>
的，可以看作是初始化，Update是每一帧画面都调用，LateUpdate是在所有Update都执行完后才调用，Fix<br>
Update是最后才调用的，因为FixedUpdate一般都是用来控制物体移动的和Rigidbody有关的行为。<br>
代码：<br>
![](https://github.com/flashowner/first3DHomework/blob/master/%E5%9B%BE%E7%89%875.PNG)
<br>
结果：<br>
![](https://github.com/flashowner/first3DHomework/blob/master/%E5%9B%BE%E7%89%876.PNG)
<br>
从结果上看，OnEnable事件是在游戏对象创建的时候调用的，OnDisable事件是在游戏对象被销毁时调用的，<br>
而OnGUI是在游戏运行的每一帧调用的<br>

### 4. 查找脚本手册，了解 GameObject，Transform，Component 对象
* 分别翻译官方对三个对象的描述（Description）
游戏对象(GameObject)是在Unity中用来表示人物，道具和风景的对象，它们并没有太多的自我实现但是它们<br>
作为部件的容器可以实现真正的功能。<br>
(Transform)变换组件决定的是在场景中每一个对象的位置，旋转和大小。每一个游戏对象都有一个变换。<br>
(Component)组件是一切附加到物体的基类<br>
* 描述下图中 table 对象（实体）的属性、table 的 Transform 的属性、 table 的部件<br>
table是一个3D部件是一个立方体，它的名字叫table，它的Transform属性有三个特性position,rotation,<br>
scale，分别表示它在世界地图的位置，旋转和大小，可以看出table的位置是(0,0,0)，它并没有旋转，而且<br>
从大小可以看出它是一个长宽高都是1的立方体。table的部件有Transform:游戏对象的转换，Mesh Henderer<br>
:游戏对象的渲染，Mateirals:游戏对象的材质，Box Collider是游戏对象的碰撞器<br>
UML图：<br>
![](https://github.com/flashowner/first3DHomework/blob/master/%E5%9B%BE%E7%89%877.PNG) <br>

### 5. 整理相关学习资料，编写简单代码验证以下技术的实现：
* 查找对象
* 添加子对象
* 遍历对象树
* 清除所有子对象<br>
代码：<br>
![](https://github.com/flashowner/first3DHomework/blob/master/%E5%9B%BE%E7%89%878.PNG) <br>

### 6. 资源预设（Prefabs）与 对象克隆 (clone)
预设可以将制作的游戏对象弄成一个模型，在以后需要使用的时候只需要将它拖出去就可以了，减少了重复的操作<br>
，而且在预设的修改可以应用到所有用该预设制成的物体；可以把预制看成类，把克隆看成实例，克隆只是复制一个<br>
对象生成的实例而已，和原来的对象并没有关联，而预设生成的实例是从预设中生成的实例，修改预设可以在实例上<br>
应用相同的改变；<br>
预设：<br>
![](https://github.com/flashowner/first3DHomework/blob/master/%E5%9B%BE%E7%89%879.PNG) <br>
实例化预设代码：<br>
![](https://github.com/flashowner/first3DHomework/blob/master/%E5%9B%BE%E7%89%8710.PNG) <br>

### 7. 尝试解释组合模式（Composite Pattern / 一种设计模式）。使用 BroadcastMessage() 方法
组合模式，将对象组合成树形结构以表示'部分-整体'的层次结构。组合模式使得用户对单个对象和组合对象的使用<br>
具有一致性。<br>
代码：<br>
