using UnityEngine;

public class QuitOnEsc : MonoBehaviour
{
    void Update()
    {
        // Kiểm tra nếu phím ESC được nhấn
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Thoát khỏi ứng dụng
            Application.Quit();

            // Chỉ dùng cho Editor, giúp dừng chơi khi chạy trong Unity Editor
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#endif
        }
    }
}
