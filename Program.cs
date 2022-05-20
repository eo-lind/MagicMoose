using System;

// creates an object using Random class
Random r = new Random();

 int genRand= r.Next(-1,20);


Main();

void Main()
{
    // Let the moose speak!
    MooseSays("Ask the all-knowing Magic Moose a question.");


}

void MooseSays(string message)
{
    Console.WriteLine($@"
                                      _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}

Console.Write("Please type your question: ");

string userQuestion = Console.ReadLine();

if (string.IsNullOrWhiteSpace(userQuestion))
{
    Console.WriteLine("You didn't type a question. I guess you know it all.");
} else if (userQuestion != "")
{
    Console.WriteLine($"You asked: {userQuestion} - Here's what I have to say about that: ANSWERS GO HERE {genRand}");
}

