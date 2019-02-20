using System.IO;

namespace ContentManagementSystem.Pages.CMS.Pages
{
    public class PagesLogic
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="path">example: "c:\Top-Level Folder\SubFolder"</param>
        public void CreateFolder(string @path)
        {
            Directory.CreateDirectory(path);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="path">example: "c:\Top-Level Folder"</param>
        /// <param name="folderName">example: SubFolder</param>
        public void CreateFolder(string @path, string @folderName)
        {
            string finalLocation = Path.Combine(path, folderName);
            Directory.CreateDirectory(path);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="path">example: "D:\Top-Level Folder\SubFolder\MyNewFile.cs";</param>
        public void CreateFile(string @path)
        {
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            else
            {
                return;
            }
        }

        /// <summary>
        /// useless?
        /// </summary>
        /// <param name="inputFilePath"></param>
        /// <param name="outputFilePath"></param>
        public static void CopyPage(string inputFilePath, string outputFilePath)
        {
            File.Copy(inputFilePath, outputFilePath);
        }
    }
}