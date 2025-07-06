using System;
public class Signal
{
    public string Name { get; set; }
    public double[] Data { get; set; }
    public double[] Time { get; set; }
    public static int Count { get; private set; } = 0;

    public Signal(string name, double[] data, double[] time)
    {
        Name = name;
        Data = data;
        Time = time;
        Count++;
    }

    public void CleanNoise()
    {
        for (int i = 0; i < Data.Length; i++)
        {
            if (Data[i] < 0)
                Data[i] = 0;
        }
    }
    public void PrintInfo()
    {
        Console.WriteLine($"Signal:{Name}");
        for (int i = 0; i < Data.Length; i++)
        {
            Console.WriteLine($"Time: {Time[i]:F2}, Data: {Data[i]:F2}");
        }
    }
    public double[] GetData(double startTime, double endTime)
    {
        int count = 0;
        for (int i = 0; i < Time.Length; i++)
        {
            if (Time[i] >= startTime && Time[i] <= endTime)
            {
                count++;
            }
        }
        double[] result = new double[count];
        int index = 0;

        for (int i = 0; i < Time.Length; i++)
        {
            if (Time[i] >= startTime && Time[i] <= endTime)
            {
                result[index++] = Data[i];
            }
        }

        return result;
    }
    public double GetVariance()
    {
        double average = 0;
        foreach (double val in Data)
            average = average + val;
        average /= Data.Length;

        double variance = 0;
        foreach (double val in Data)
            variance += (val - average) * (val - average);

        return variance / Data.Length;
    }
    public static Signal Merge(Signal signal1, Signal signal2)
    {
        int len1 = signal1.Time.Length;
        int len2 = signal2.Time.Length;
        int totalLen = len1 + len2;


        double[] mergedTime = new double[totalLen];
        double[] mergedData = new double[totalLen];


        for (int i = 0; i < len1; i++)
        {
            mergedTime[i] = signal1.Time[i];
            mergedData[i] = signal1.Data[i];
        }

        for (int i = 0; i < len2; i++)
        {
            mergedTime[len1 + i] = signal2.Time[i];
            mergedData[len1 + i] = signal2.Data[i];
        }

        for (int i = 0; i < totalLen - 1; i++)
        {
            for (int j = i + 1; j < totalLen; j++)
            {
                if (mergedTime[i] > mergedTime[j])
                {
                    double tempTime = mergedTime[i];
                    mergedTime[i] = mergedTime[j];
                    mergedTime[j] = tempTime;

                    double tempData = mergedData[i];
                    mergedData[i] = mergedData[j];
                    mergedData[j] = tempData;
                }
            }
        }

        return new Signal(signal1.Name + "_" + signal2.Name, mergedData, mergedTime);
    }
    public static int GetRecordsNumber()
    {
        return Count;
    }
}
public class Machine
{
    public string Name { get; set; }
    public Signal[] Signals { get; private set; }
    private int currentSignalIndex;
    private const int MAX_SIGNALS = 10;

    public Machine(string name)
    {
        Name = name;
        Signals = new Signal[MAX_SIGNALS];
        currentSignalIndex = 0;
    }
    public void AddSignal(Signal signal)
    {
        if (currentSignalIndex < MAX_SIGNALS)
        {
            Signals[currentSignalIndex++] = signal;
        }
        else
        {
            Console.WriteLine("Nu pot fi adaugate alte semnale.");
        }
    }
    public void ChangeSignal(int index, Signal signal)
    {
        if (index >= 0 && index < currentSignalIndex)
        {
            Signals[index] = signal;
        }
        else
        {
            Console.WriteLine("Index invalid.");
        }
    }
    public Signal GetMaxSignal(double time)
    {
        double maxVal = double.MinValue;
        Signal maxSignal = null;

        foreach (Signal signal in Signals)
        {
            if (signal != null)
            {
                double[] values = signal.GetData(time - 1, time + 1);
                foreach (double val in values)
                {
                    if (val > maxVal)
                    {
                        maxVal = val;
                        maxSignal = signal;
                    }
                }
            }
        }
        return maxSignal;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Machine: {Name}");
        for (int i = 0; i < currentSignalIndex; i++)
        {
            Signals[i].PrintInfo();
            Console.WriteLine();
        }
    }
}


public interface ITest
{
    void RunTest();
    string GetTestResults();

}

public class TestMachineSignalOscillations : Machine, ITest
{
    public static int threshold = 1;
    private string testName;
    private string result;

    public TestMachineSignalOscillations(string name) : base(name)
    {
        testName = name;
    }
    public void RunTest()
    {
        result = "A trecut testul!";

        foreach (var signal in Signals)
        {
            if (signal == null) continue;
            for (int i = 1; i < signal.Data.Length; i++)
            {
                if (Math.Abs(signal.Data[i] - signal.Data[i - 1]) > threshold)
                {
                    result = "Test picat: Oscilatie detectată!";
                    return;
                }
            }
        }
    }

    public string GetTestResults()
    {
        return $"{testName} Results:{result}";
    }
}

public class TestMachineSignalNoise : Machine, ITest
{
    private string testName;
    private string result;

    public TestMachineSignalNoise(string name) : base(name)
    {
        testName = name;
    }
    public void RunTest()
    {
        result = "A trecut testul!";

        foreach (var signal in Signals)
        {
            if (signal == null) continue;
            double variance = signal.GetVariance();

            foreach (double d in signal.Data)
            {
                if (d > variance)
                {
                    result = "Test picat: apare zgomot!";
                    return;
                }
            }
        }
    }


    public string GetTestResults()
    {
        return $"{testName}:{result}";
    }
}
public class TestMachines<T> where T : ITest
{
    private List<T> tests = new List<T>();

    public void AddTest(T test) => tests.Add(test);

    public void RunTests()
    {
        foreach (var test in tests)
            test.RunTest();
    }

    public void PrintResults()
    {
        foreach (var test in tests)
            Console.WriteLine(test.GetTestResults());
    }
}



class Program
{
    static void Main(string[] args)
    {
        Machine machine = new Machine("My Machine");
        Random random = new Random();
        for (int i = 0; i < 5; i++)
        {
            double[] data = new double[7];
            double[] time = new double[7];
            for (int j = 0; j < 7; j++)
            {
                data[j] = random.NextDouble() * 20 - 10;
                time[j] = random.NextDouble() + j;
            }
            Signal signal = new Signal("Signal" + i, data, time);
            machine.AddSignal(signal);
        }
        Console.WriteLine("Raw signals: ");
        machine.PrintInfo();

        Console.WriteLine();

        Signal signal1 = machine.Signals[0];
        Signal signal2 = machine.Signals[1];
        Signal mergedSignal = Signal.Merge(signal1, signal2);
        mergedSignal.PrintInfo();

        Console.WriteLine();
        Console.WriteLine("Clean signals:");
        foreach (Signal signal in machine.Signals)
        {
            if (signal != null)
            {
                signal.CleanNoise();
            }

        }
        machine.PrintInfo();
        Console.WriteLine();
        Console.WriteLine("The signal with the highest value in time [4,6]: ");
        Signal maxSignal = machine.GetMaxSignal(5);
        maxSignal?.PrintInfo();

        TestMachineSignalOscillations testOscillations = new TestMachineSignalOscillations("Oscillations Test");
        TestMachineSignalOscillations.threshold = 1;
        testOscillations.AddSignal(machine.Signals[0]);
        testOscillations.AddSignal(machine.Signals[1]);
        testOscillations.AddSignal(machine.Signals[2]);
        testOscillations.AddSignal(machine.Signals[3]);
        testOscillations.AddSignal(machine.Signals[4]);

        TestMachineSignalNoise testNoise = new TestMachineSignalNoise("Noise Test");
        testNoise.AddSignal(machine.Signals[0]);
        testNoise.AddSignal(machine.Signals[1]);
        testNoise.AddSignal(machine.Signals[2]);
        testNoise.AddSignal(machine.Signals[3]);
        testNoise.AddSignal(machine.Signals[4]);

        TestMachines<ITest> testMachines = new TestMachines<ITest>();
        testMachines.AddTest(testOscillations);
        testMachines.AddTest(testNoise);
        testMachines.RunTests();
        testMachines.PrintResults();

    }
}




