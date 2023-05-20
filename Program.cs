using System;
namespace homework2{
    class program{
        static void Main(string[]args){
            bool continueProgram = true;

            while (continueProgram) {
                Console.Write("Enter a DNA sequence: ");
                string halfDNASequence = Console.ReadLine();

                if (IsValidSequence(halfDNASequence)) {
                    Console.WriteLine("Current half DNA sequence: " + halfDNASequence);

                    Console.WriteLine("Do you want to replicate it? (Y/N): ");
                    char choice;
                    choice = Console.ReadKey().KeyChar;
                   
                   while (choice != 'Y' && choice != 'N'){
                        choice = Console.ReadKey().KeyChar;
                        Console.WriteLine();

                    if (choice == 'Y') {
                        string replicatedSequence = ReplicateSeqeunce(halfDNASequence);
                        Console.WriteLine("Replicated half DNA sequence: " + replicatedSequence);
                    } else if (choice == 'N') {
                    //skip
                    } else {
                    Console.WriteLine("Please input Y or N.");
                    Console.WriteLine("Do you want to replicate it? (Y/N): ");
                    continue;
                    }
                   }
                    
                
                } else {
                    Console.WriteLine("That half DNA sequence is invalid."); 
                }
                
                Console.WriteLine("Do you want to process another sequence? (Y/N): ");
                    char continueChoice;
                    do{
                    continueChoice = Console.ReadKey().KeyChar;
                    Console.WriteLine();

                    if (continueChoice == 'N'){
                        continueProgram = false;
                    } else if (continueChoice != 'Y'){
                        Console.WriteLine("Please input Y or N.");
                        Console.WriteLine("Do you want to process another sequence? (Y/N): ");
                    }
                    }while (continueChoice != 'Y' && continueChoice != 'N');
                   
            
            
        }
    }

        static bool IsValidSequence(string halfDNASequence) {
	        foreach(char nucleotide in halfDNASequence) {
    	        if(!"ATCG".Contains(nucleotide)) {
        	        return false;
    	        }
	        }
	        return true;
        }


        static string ReplicateSeqeunce(string halfDNASequence) {
	        string result = "";
	        foreach(char nucleotide in halfDNASequence){
    	        result += "TAGC"["ATCG".IndexOf(nucleotide)];
	            }
	        return result;
        }
        }
    }

