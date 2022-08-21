using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOpsConceptPractice
{
    /* In C# An indexers  indexer is a class property that allows you to access a member variable of a class or struct  using the features of an array 
       In C#, indexers are created using this keyword. Indexers in C# are applicable on both classes and structs.

       Instance of this class can be accessed by using array operator([])
       Defining an indexer allows you to create a class like that can allows its items to be accessed an array.  
       Instances of that class can be accessed using the [] array access operator.
       Creating an Indexer
       <modifier> <return type> this [argument list]  
       {  
         get  
         {  
           // your get block code  
         }  
          set  
         {  
          // your set block code  
         }  
         }  
     
         <modifier>
         can be private, public, protected or internal.
         <return type>
         can be any valid C# types.
         this
         this is a special keyword in C# to indicate the object of the current class.
         [argument list]
          The formal-argument-list specifies the parameters of the indexer.

                    Important points to remember on indexers: 
          Indexers are always created with this keyword.
          Parameterized property are called indexer.
          Indexers are implemented through get and set accessors for the [ ] operator.
          ref and out parameter modifiers are not permitted in indexer.
      The formal parameter list of an indexer corresponds to that of a method and at least one parameter should be specified.
      Indexer is an instance member so can't be static but property can be static.
    Indexers are used on group of elements.
    Indexer is identified by its signature where as a property is identified it's name.
    Indexers are accessed using indexes where as properties are accessed by names.
    Indexer can be overloaded.
    Indexer are defined in pretty much same way as properties, with get and set functions. 
    The main difference is that the name of the indexer is the keyword this.
     */

    public class Indexers
    {
        class IndexerClass
        {
            
            private string[] names = new string[10];
            public string this[int i]
            {
                get
                {
                    return names[i];
                }
                set
                {
                    names[i] = value;
                }
            }       
        }
        public void index()
        {
            IndexerClass Team = new IndexerClass();
            Team[0] = "Rocky";
            Team[1] = "Teena";
            Team[2] = "Ana";
            Team[3] = "Victoria";
            Team[4] = "Yani";
            Team[5] = "Mary";
            Team[6] = "Gomes";
            Team[7] = "Arnold";
            Team[8] = "Mike";
            Team[9] = "Peter";
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Team[i]);
            }
            Console.ReadKey();
        }
        public class Employee
        {
            private readonly int Value;
            private int[] age = new int[3];
            public int this[int index]
            {
                
                set
                {
                    if(index>=0 && index<age.Length)
                    {
                        if(value>0)
                        {
                            age[index] = Value;
                        }

                    }
                    

                    
                }
                get
                {
                    return age[index];
                }

            }
        }
    }
}
