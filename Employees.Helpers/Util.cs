namespace Employees.Helpers;
public static class Util
{
    public static String AskForString(string prompt){

        
            bool success = false;
            string answer;
            do
            {
                Console.WriteLine($"{prompt}");
                answer = Console.ReadLine()!;

                if(string.IsNullOrWhiteSpace(answer)){
                    Console.WriteLine($"You must enter a valid {prompt}");
                }else{
                    success = true;
                }
                
            } while (!success);

            return answer;
    }

    internal static uint AskForUInt(string prompt)
    {
        do
        {
            string input = AskForString(prompt);

            if(uint.TryParse(input,out uint result)){
                return result;
            }
        } while (true);
    }
}
