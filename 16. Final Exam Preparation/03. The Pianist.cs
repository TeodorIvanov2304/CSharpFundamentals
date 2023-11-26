/*
You are a pianist, and you like to keep a list of your favorite piano pieces. Create a program to help you organize it and add, change, remove pieces from it!
On the first line of the standard input, you will receive an integer n – the number of pieces you will initially have. On the next n lines, the pieces themselves will follow with their composer and key, separated by "|" in the following format: "{piece}|{composer}|{key}".
Then, you will be receiving different commands, each on a new line, separated by "|", until the "Stop" command is given:
•	"Add|{piece}|{composer}|{key}":
o	You need to add the given piece with the information about it to the other pieces and print:
"{piece} by {composer} in {key} added to the collection!"
o	If the piece is already in the collection, print:
"{piece} is already in the collection!"
•	"Remove|{piece}":
o	If the piece is in the collection, remove it and print:
"Successfully removed {piece}!"
o	Otherwise, print:
"Invalid operation! {piece} does not exist in the collection."
•	"ChangeKey|{piece}|{new key}":
o	If the piece is in the collection, change its key with the given one and print:
"Changed the key of {piece} to {new key}!"
o	Otherwise, print:
"Invalid operation! {piece} does not exist in the collection."
Upon receiving the "Stop" command, you need to print all pieces in your collection in the following format:
"{Piece} -> Composer: {composer}, Key: {key}"
Input/Constraints
•	You will receive a single integer at first – the initial number of pieces in the collection.
•	For each piece, you will receive a single line of text with information about it.
•	Then you will receive multiple commands in the way described above until the command "Stop".
Output
•	All the output messages with the appropriate formats are described in the problem description.
 
 
 
*/
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