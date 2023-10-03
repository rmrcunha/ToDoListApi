namespace ToDo.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Tarefa
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public bool Pronto { get; set; }
        public int UsuarioId { get; set; }
    }
}
