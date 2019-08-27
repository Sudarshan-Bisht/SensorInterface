How to run the app;
1. On command prompt go to the respective location where HelloSensor.dll is located (In my case its C:\DC_Assignment\HelloSensor\bin\Debug\netcoreapp2.0).
2. Type; dotnet HelloSensor.dll 10.0.0.1 5004  (There is no .exe gets generated in .NET Core 2.0, so this is the way we have to run console app in latest environment ).
3. When scan start command is directed, frames (dummy) will get stored in same folder, a log file will also generated contains tracing.



Solution structure;
1. Open HelloSensor.sln in latest version of VS2017 which supports .NET Core 2.0
2. HelloSensor; is a main console application, helping user to interact with sensor.
3. SensorAPILib; is a class library, simulating sensor's functionality.
4. SensorCommon; contains common classes used between console app and library.
5. UnitTestsHelloSensor; is unit test project, there are 9 unit tests, testing command parsing functionality of HelloSensor.


Assumptions;
1. It is assumed that user enters IP Address and port number in correct format. IP Address and Port number's integrity is not checked.
2. Sensor's settings are assumed to have frame number and scan mode.