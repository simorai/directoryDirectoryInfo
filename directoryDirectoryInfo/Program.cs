namespace directoryDirectoryInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Caminho do diretório a ser analisado.
            /// </summary>
            string path = @"C:\Projetos\Udemy\FileManipulation";
			try
			{
                /// <summary>
                /// Enumera todos os subdiretórios no caminho especificado.
                /// </summary>
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach(string s in folders)
                {
                    Console.WriteLine(s);
                }
                /// <summary>
                /// Enumera todos os arquivos no caminho especificado.
                /// </summary>
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES: ");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
                /// <summary>
                /// Cria um novo diretório dentro do caminho especificado.
                /// </summary>
                Directory.CreateDirectory(path + @"\newfolder");
			}
			catch (IOException e)
			{
                /// <summary>
                /// Captura e trata exceções de E/S que possam ocorrer durante as operações com diretórios e arquivos.
                /// </summary>
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
			}
        }
    }
}
