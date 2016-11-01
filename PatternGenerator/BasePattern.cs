using System;
using System.IO;

namespace PatternGenerator
{
    public abstract class BasePattern
    {
        protected string value;

        public void Save()
        {
            string strFilename = Console.ReadLine();
            //does the filename exists?
            if (File.Exists(strFilename))
            {
                File.WriteAllText(strFilename, value);
            }
            else
            {
                //if the pattern file doesnt exists a text file will be created 
                StreamWriter wr = File.CreateText(strFilename);
                //under construction ... code to save the generated pattern from the different classes
                wr.WriteLineAsync(value);
                wr.Close();
                //re = File.OpenText(strFilename);
            }    
        }
        public abstract void CreatePattern();
    }
}

