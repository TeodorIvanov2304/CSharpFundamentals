namespace _03._The_Pianist
{
    class Piece
    {
        public Piece(string pieceName, string composer, string key)
        {
            PieceName = pieceName;
            Composer = composer;
            Key = key;
        }

        public string PieceName { get; set; }
        public string Composer { get; set; }
        public string Key { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Piece> listOfPieces = new List<Piece>();
            int numberOfPieces = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfPieces; i++)
            {
                string pieceInfo = Console.ReadLine();
                string[] pieceTokens = pieceInfo.Split("|").ToArray();
                string pieceName = pieceTokens[0];
                string composer = pieceTokens[1];
                string key = pieceTokens[2];
                Piece piece = new Piece(pieceName, composer, key);
                listOfPieces.Add(piece);
            }

            string commands = "";
            while ((commands = Console.ReadLine()) != "Stop")
            {
                string[] commandTokens = commands.Split("|").ToArray();
                string command = commandTokens[0];
                string piece = commandTokens[1];
                
                switch (command)
                {
                    case "Add":
                        piece = commandTokens[1];
                        string composer = commandTokens[2];
                        string key = commandTokens[3];
                        Piece newPiece = listOfPieces.FirstOrDefault(p => p.PieceName == piece);


                        if (newPiece != null)
                        {
                            Console.WriteLine($"{piece} is already in the collection!");
                            
                        }
                        else
                        {   //Създаваме ново парче, за да го добавим. Тук доста време се опитвах, да добавя несъществуващ piece, т.е опитвахе се да добавя newPiece, който ми е само за проверка!!!
                            //Даваше грешка Object reference not set to an instance of an object
                            Piece pieceToAdd = new Piece(piece, composer, key);
                            listOfPieces.Add(pieceToAdd);
                            Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                        }
                        break;
                    case "Remove":
                        piece = commandTokens[1];
                        newPiece = listOfPieces.FirstOrDefault(p => p.PieceName == piece);
                        if (newPiece != null)
                        {
                            listOfPieces.Remove(newPiece);
                            Console.WriteLine($"Successfully removed {piece}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        }
                        break;
                    case "ChangeKey":
                        piece = commandTokens[1];
                        string newKey = commandTokens[2];
                        newPiece = listOfPieces.FirstOrDefault(p => p.PieceName == piece);
                        if (newPiece != null)
                        {
                            newPiece.Key = newKey;
                            Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        }
                        break;

                }


            }
            foreach (Piece p in listOfPieces)
            {
                Console.WriteLine($"{p.PieceName} -> Composer: {p.Composer}, Key: {p.Key}");
            }
        }
    }
}