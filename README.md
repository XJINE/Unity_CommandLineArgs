# Unity_CommandLineArgs

Get command line args more easily.

## How to Use

### Import to Your Project

If you want to import this repository as submodule in your project.

```
git submodule add -b submodule https://github.com/XJINE/Unity_CommandLineArgs.git Assets/Packages/XJGUI
```

### Get a Value

There are some functions to get command line args values.
These functions return success to get or not, and output the value to out~.

```
int value;
…
CommandLineArgs.GetValueAsInt("paramName", out value);
CommandLineArgs.GetValueAsFloat("paramName", out value);
CommandLineArgs.GetValueAsString("paramName", out value);

int[] values;
…
CommandLineArgs.GetValuesAsInt("paramName", out values);
CommandLineArgs.GetValuesAsFloat("paramName", out values);
CommandLineArgs.GetValuesAsString("paramName", out values);
```

Also you can check the parameter is defined or not.
Following function simply returns the "paramName" is defined or not.

```
CommandLineArgs.HasParameter("paramName");
```

### Naming Rule

There are 2 rule to use this utility.

(1) Parameter names are must be start with "-".
And the values are must not be start with "-" and must not be include ",".

*EX: "-SampleParamA" is good, "SampleParamA" or "SampleParam,A" are bad.*

(2) Array parameters should be define with ", ". Certainly, you can define array parameters with " ".
However, if you have to deal single array parameters as array, you must use ", ".

*EX: "-SampleParamsA 0 1 2 3 4 5" and "-SampleParamsB 0," are both deal as array.*

### Ex.

```
-SampleA 0 -SamplesA 0 1 2 3 4 -popup-window -SampleB -SamplesB A,
```
Following table shows dealt with this command line args.

| KEY           | VALUE           |
|:--------------|:----------------|
| -SampleA      | 0               |
| -SamplesA     | {0, 1, 2, 3, 4} |
| -popup-window | null            |
| -SampleB      | null            |
| -SamplesB     | {A}             |
