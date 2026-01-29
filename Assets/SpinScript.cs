using UnityEngine;
using UnityEngine.InputSystem;

//只有继承它，脚本才能挂载到游戏对象上
public class NewMonoBehaviourScript : MonoBehaviour

{
    private GameObject mCube;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //在场景中找到名为 “Cube” 的游戏对象，将其赋值给mCube变量，后续可通过mCube操作这个 Cube。
        mCube = GameObject.Find("Cube");
    }

    // Update is called once per frame
    void Update()
    {//当前挂载这个脚本的游戏对象的Transform组件,让当前游戏对象每帧绕 Y 轴旋转 1 度
        transform.Rotate(0, 1f, 0);
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            //mCube.GetComponent<Renderer>()：获取mCube（即场景中名为 “Cube” 的对象）上的Renderer组件；
            //Renderer是负责物体渲染的组件，只有通过它才能修改物体的材质、颜色等视觉属性；
//           var是自动推断变量类型的关键字，这里cubeRenderer的类型会被推断为Renderer。
            var cubeRenderer = mCube.GetComponent<Renderer>();
            cubeRenderer.material.SetColor("_Color", Color.green);
        }
    }
}
