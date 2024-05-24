using System;
using System.Collections.Generic;
public class Note{
  public string name;
  public string description;
  public Note(string name, string description){
    this.name=name;
    this.description=description;
  }
}

public  class Program 
{
    static void Main(string[] args)
    {
       List<Note> notes = new List<Note>();
     while(true){
      top:
      Console.WriteLine("enter the name of the note");
      string name = Console.ReadLine();
      Console.WriteLine("enter the description of the note");
      string description = Console.ReadLine();
      notes.Add(new Note(name,description));
 top2:
       top1:
      Console.WriteLine("select from the option:");
        Console.WriteLine("1.add note");
        Console.WriteLine("2.delete note");
        Console.WriteLine("3.see note");
        Console.WriteLine("4.Replace note");
        Console.WriteLine("5.exit");
        int option = Convert.ToInt32(Console.ReadLine());
   if(option==1){
goto top;
   }else if(option == 2) {
    Console.WriteLine("Enter the name of the note to be deleted:");
    string deleteNote = Console.ReadLine();

    // Collect notes to remove
    List<Note> notesToRemove = new List<Note>();

    foreach(Note note in notes) {
        if(deleteNote == note.name) {
            notesToRemove.Add(note);
        }
    }

    if (notesToRemove.Count > 0) {
        foreach(Note note in notesToRemove) {
            notes.Remove(note);
        }
        Console.WriteLine($"Notes with the name '{deleteNote}' have been deleted.");
    } else {
        Console.WriteLine("Note not found");
    }
}

 else if(option==3){
     Console.WriteLine("enter the name of the note to be viewed");
     foreach(Note note in notes){
       Console.WriteLine(note.name);
         Console.WriteLine(note.description);
      
     }
     goto top1;
   }
        else if(option==4){
          foreach(Note note in notes){
            Console.WriteLine("enter the name of the note to be replaced");
            if(note.name==Console.ReadLine()){
              Console.WriteLine("enter the new name of the note");
              note.name=Console.ReadLine();
              Console.WriteLine("enter the new description of the note");
              note.description=Console.ReadLine();
            }
          }
          goto top2;
        }
        else{
          break;
        }
      
      }
      }
      
}
