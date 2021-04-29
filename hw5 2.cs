using System;

namespace hw._5_2
{
    class Program
    {
        //Current half DNA sequence : "
        //"That half DNA sequence is invalid."
        //"Do you want to replicate it ? (Y/N) : "
        //"Please input Y or N."
        //"Replicated half DNA sequence : " 

        static string g = Console.ReadLine();
        static char Y; 
        
        static void Main(string[] args)
        {
            
                IsValidSequence(g);
                if (IsValidSequence(g) == true)
                {
                    Console.WriteLine("Current half DNA sequence: {0} ", g);
                    Console.Write("Do you want to replicate it ? (Y/N) : ");
                    Y = char.Parse(Console.ReadLine());
                    while (Y != 'Y' && Y != 'N')
                    {
                        Console.WriteLine("Please input Y or N.");
                        Console.Write("Do you want to replicate it ? (Y/N) : ");
                        Y = char.Parse(Console.ReadLine());
                    }
                    if (Y == 'Y')
                    {
                        ReplicateSeqeunce(g);
                        Console.WriteLine("Replicated half DNA sequence : {0}", ReplicateSeqeunce(g));
                        Console.Write("Do you want to process another sequence ? (Y/N) : ");
                        Y = char.Parse(Console.ReadLine());
                        while (Y != 'Y' && Y != 'N')
                        {
                            Console.WriteLine("Please input Y or N.");
                        }
                        if (Y == 'Y')
                        {
                            Console.Write("Do you want to replicate it ? (Y/N) : ");
                            while (Y == 'Y')
                            {
                                Console.WriteLine("Replicated half DNA sequence : {0}", ReplicateSeqeunce(g));
                                Console.Write("Do you want to process another sequence ? (Y/N) : ");
                                Y = char.Parse(Console.ReadLine());
                                while (Y != 'Y' && Y != 'N')
                                {
                                    Console.WriteLine("Please input Y or N.");
                                }
                            }
                        }
                        if (Y == 'N')
                        {
                            Console.WriteLine("");
                        }

                    }
                    if (Y == 'N')
                    {
                        Console.WriteLine("");
                    }
                }
            else
            {
                Console.Write("That half DNA sequence is invalid.");
            }
        }

        static bool IsValidSequence(string halfDNASequence)
        {
            foreach (char nucleotide in halfDNASequence)
            {
                if (!"ATCG".Contains(nucleotide))
                {
                    return false;
                }
            }
            return true;
        }

        static string ReplicateSeqeunce(string halfDNASequence)
        {
            string result = "";
            foreach (char nucleotide in halfDNASequence)
            {
                result += "TAGC"["ATCG".IndexOf(nucleotide)];
            }
            return result;
        }

    }
}
