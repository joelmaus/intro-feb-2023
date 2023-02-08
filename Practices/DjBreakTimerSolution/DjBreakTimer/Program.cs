// See https://aka.ms/new-console-template for more information

using System.Xml;

int breakLengthAsNumber;
TimeSpan songLengthAsTimeSpan;


while (true)
{
    Console.WriteLine("How many mintues is your break: ");
    var breakLength = Console.ReadLine();
    if (int.TryParse(breakLength, out breakLengthAsNumber))
    {     
        break;
    }  
}

breakLengthAsNumber *= 60;

while (true)
{

    Console.WriteLine("How long is the song (minutes:seconds): ");
    var songLength = "00:" + Console.ReadLine();
    if (TimeSpan.TryParse(songLength, out songLengthAsTimeSpan))
    {
        break;
    }

}

var totalMinutesSong = songLengthAsTimeSpan.Minutes;
var totalSecondsSong = songLengthAsTimeSpan.Seconds;

totalMinutesSong *= 60;

var beginSongTime = breakLengthAsNumber - totalMinutesSong - totalSecondsSong;

var minutesLeft = beginSongTime / 60;
var secondsLeft = beginSongTime % 60;


var currentTime = DateTime.Now;

currentTime = currentTime.AddMinutes(minutesLeft);
currentTime= currentTime.AddSeconds(secondsLeft);


Console.WriteLine("Break begins in 2 seconds.\n\n");
Thread.Sleep(2000);
Console.BackgroundColor = ConsoleColor.Blue;
while (minutesLeft >= 0 && secondsLeft >=0)
{
    Thread.Sleep(1000);
    Console.Clear();
    Console.WriteLine("Begin song in ");
    Console.WriteLine(minutesLeft + ":" + secondsLeft);
    secondsLeft -= 1;

    if (secondsLeft<0)
    {
        secondsLeft = 59;
        minutesLeft -= 1;
    }
   
}

Console.BackgroundColor = ConsoleColor.Green;
Console.WriteLine("Start song\n");

totalMinutesSong /= 60;
minutesLeft = totalMinutesSong;
secondsLeft = totalSecondsSong;

while (minutesLeft >= 0 && secondsLeft >= 0)
{
    Thread.Sleep(1000);
    Console.Clear();
    Console.WriteLine("Start Song\n");
    Console.WriteLine(minutesLeft + ":" + secondsLeft);
    secondsLeft -= 1;

    if (secondsLeft < 0)
    {
        secondsLeft = 59;
        minutesLeft -= 1;
    }

}
