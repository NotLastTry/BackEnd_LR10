using Microsoft.AspNetCore.Mvc;

namespace BackEnd_Нагорнов_А.В._ЛР10.Controllers
{
    public class ResponseController : Controller
    {
        //Метод, возвращающий HTML.
        [HttpGet("html")]
        public IActionResult GetHtml()
        {
            return Content("<html><body><h1>Hello, World!</h1></body></html>", "text/html");
        }
        //Метод, возвращающий JSON.
        [HttpGet("json")]
        public JsonResult GetJson()
        {
            string obj = "dummy";
            return Json(obj);
        }
        //Метод, возвращающий файл.
        [HttpGet("file")]
        public FileResult GetFile()
        {
            var filePath = "D:\\Документы\\Лабораторные работы\\2_год\\4_семестр\\BackEnd\\10\\BackEnd_Нагорнов_А.В._ЛР10\\file.txt";
            var fileType = "application/octet-stream";
            return PhysicalFile(filePath, fileType, "file.txt");
        }
        // Метод, возвращающий код состояния
        [HttpGet("status")]
        public StatusCodeResult GetStatus()
        {
            return NoContent(); //Возвращает 204 No Content.
        }
    }
}
