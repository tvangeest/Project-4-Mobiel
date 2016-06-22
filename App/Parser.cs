using System;
using System.IO;
using System.Collections.Generic;

public class Parser
{
    static List<List<String>> readCSV(StreamReader reader)
    {
        List<List<String>> convertedCSV = new List<List<string>>();

        while (!reader.EndOfStream)
        {
            String line = reader.ReadLine();
            string[] values = line.Split(',');
            List<String> listValues = new List<String>(values);
            convertedCSV.Add(listValues);
        }

        return convertedCSV;
    }

    List<List<List<String>>> CVSLoader(params string[] paths)
    {
        List<List<List<String>>> allLists = new List<List<List<String>>>();

        for (int i = 0; i < paths.Length; i++)
        {
            StreamReader newReader = new StreamReader(File.OpenRead(paths[i]));
            List<List<String>> newList = readCSV(newReader);
            allLists.Add(newList);
        }

        // StreamReader trommelReader = new StreamReader(File.OpenRead(@"C:\Users\Evelyn\Text\School\Project 4\Fietstrommels-maart-2013.csv"));
        // StreamReader diefstalReader = new StreamReader(File.OpenRead(@"C:\Users\Evelyn\Text\School\Project 4\fietsdiefstal-rotterdam-2011-2013.csv"));
        
        return allLists;
    }
}