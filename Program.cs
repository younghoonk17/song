using System;
using System.Collections.Generic;


namespace song
{
    class Program
    {
        static void Main(string[] args)
        {

            // List<Verse> tmp = new List<Verse>();

            // Verse newVerse = new Verse();
            // newVerse.number = 1;
            // newVerse.text = "test";

            // tmp.Add(newVerse);


            // var test = new Song();
            // test.verse = tmp;


            var file = reader(@"./찬송가.txt");


            //testing output 
            Console.WriteLine(file[0]);            
            
            
        }




        //reader to read the file
        static public string[] reader(string filelocation){
            
            string[] file = System.IO.File.ReadAllLines(filelocation);
            
            return file;
        } 
        
    }
}
