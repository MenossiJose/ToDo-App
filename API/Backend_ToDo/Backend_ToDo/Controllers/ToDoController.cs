using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace Backend_ToDo.Controllers
{
    [ApiController]
    [Route("api/todo")]
    public class ToDoController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public ToDoController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("get_tasks")]
        public IActionResult GetTasks()
        {
            string query = "SELECT * FROM todo";
            DataTable table = new DataTable();
            string sqlDatasource = _configuration.GetConnectionString("mydb");

            try
            {
                using (SqlConnection myCon = new SqlConnection(sqlDatasource))
                {
                    myCon.Open();
                    using (SqlCommand myCommand = new SqlCommand(query, myCon))
                    using (SqlDataReader myReader = myCommand.ExecuteReader())
                    {
                        table.Load(myReader);
                    }
                }
                return Ok(table);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro ao buscar tarefas: {ex.Message}");
            }
        }

        [HttpPost("add_task")]
        public IActionResult AddTask([FromBody] string task)
        {
            if (string.IsNullOrWhiteSpace(task))
                return BadRequest("A tarefa não pode estar vazia.");

            string query = "INSERT INTO todo (task) VALUES (@task)";
            string sqlDatasource = _configuration.GetConnectionString("mydb");

            try
            {
                using (SqlConnection myCon = new SqlConnection(sqlDatasource))
                {
                    myCon.Open();
                    using (SqlCommand myCommand = new SqlCommand(query, myCon))
                    {
                        myCommand.Parameters.AddWithValue("@task", task);
                        int rowsAffected = myCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            return Ok(new { message = "Tarefa adicionada com sucesso." });
                        else
                            return StatusCode(500, "Erro ao adicionar tarefa.");
                    }
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro ao adicionar tarefa: {ex.Message}");
            }
        }

        [HttpDelete("delete_task/{id}")]
        public IActionResult DeleteTask(int id)
        {
            string query = "DELETE FROM todo WHERE id = @id";
            string sqlDatasource = _configuration.GetConnectionString("mydb");

            try
            {
                using (SqlConnection myCon = new SqlConnection(sqlDatasource))
                {
                    myCon.Open();
                    using (SqlCommand myCommand = new SqlCommand(query, myCon))
                    {
                        myCommand.Parameters.AddWithValue("@id", id);
                        int rowsAffected = myCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            return Ok(new { message = "Tarefa deletada com sucesso." });
                        else
                            return NotFound("Tarefa não encontrada.");
                    }
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro ao deletar tarefa: {ex.Message}");
            }
        }
    }
}
