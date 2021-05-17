# EradicateFreeSpeech API
Using high tech AI, machine learning, quantum computing, and over 50 million gigabytes of training data, I have created an easy-to-use API to determine whether speech should be censored. Simply call the ShouldBeCensored extension method on any string of text and it returns a boolean, true if it should be censored, false if the speech should be bestowed the privilege of existing. This API is perfect for ISPs, social media platforms, news websites, and any other area where we must abolish free speech.

## Usage

In the .NET command-line interface, install the package with 

   ```dotnet add package EradicateFreeSpeech.Censorship --version 1.0.0```


In the NuGet package manager, install the package with 

   ```Install-Package EradicateFreeSpeech.Censorship -Version 1.0.0```

## Example

```using System;
using EradicateFreeSpeech;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string Test = "I love my technocratic overlords!";
            
            //Three different ways to use the method
            Console.WriteLine(Test.ShouldBeCensored()? "Wrongthink detected." : Test);
            Console.WriteLine(Censorship.ShouldBeCensored(Test) ? "Wrongthink detected." : Test);
            if (Test.ShouldBeCensored())
            {
                Console.WriteLine("Wrongthink detected.");
            }
            else {
                Console.WriteLine(Test);
            }
        }
    }
}
```

## License
To the extent possible under law,
  <a rel="dct:publisher"
     href="https://github.com/charlesteets/EradicateFreeSpeech">
    <span property="dct:title">Big Brother</span></a>
  has waived all copyright and related or neighboring rights to
  <span property="dct:title">EradicateFreeSpeech</span>.
  
  
[![License](http://i.creativecommons.org/p/zero/1.0/88x31.png)](http://creativecommons.org/publicdomain/zero/1.0/)
