namespace questionexchange
{
		public class Question
		{
        
        public static int _indexq = 0;
        public string questiontext { get; set;  }
      
    
        public Question() //schema-test: Answer a = new Answer(); Answer b = new Answer(); Console.WriteLine(a._index); Console.WriteLine(b._index);
        {
             
            _indexq++;
        }
    }

}