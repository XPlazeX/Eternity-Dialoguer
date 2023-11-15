using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eternity_Dialoger.Models
{
    class FileHandler
    {
        public static string FilePath { get; private set; }

        public static List<DialogueObject> OpenCSVFile(string path)
        {
            FilePath = path;
            StreamReader streamReader = new StreamReader(path);

            List<DialogueObject> outputList = new List<DialogueObject>();

            string[] rowData;
            char[] separators = { ';' };

            string data = streamReader.ReadLine();

            while (data != null)
            {
                rowData = data.Split(separators);

                DialogueObject d = new DialogueObject();

                if (rowData[0] == "1")
                    d.IsHero = true;
                else
                    d.IsHero = false;

                d.CharacterID = int.Parse(rowData[1]);
                d.VoiceID = int.Parse(rowData[2]);
                d.DurationID = int.Parse(rowData[3]);
                d.Text = rowData[4];

                outputList.Add(d);

                data = streamReader.ReadLine();
            }
            streamReader.Close();

            return outputList;
        }

        public static void WriteCSVFile(string path, List<DialogueObject> dialogObjects)
        {
            FilePath = path;
            StreamWriter streamWriter = new StreamWriter(path, false);

            for (int i = 0; i < dialogObjects.Count; i++)
            {
                string[] datas = new string[5];

                if (dialogObjects[i].IsHero)
                    datas[0] = "1";
                else
                    datas[0] = "0";

                datas[1] = dialogObjects[i].CharacterID.ToString();
                datas[2] = dialogObjects[i].VoiceID.ToString();
                datas[3] = dialogObjects[i].DurationID.ToString();
                datas[4] = dialogObjects[i].Text;

                streamWriter.WriteLine(string.Join(";", datas));
            }

            streamWriter.Close();
        }
    }
}
