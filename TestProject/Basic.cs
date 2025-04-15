namespace TestProject;

/// <summary>
/// Represents an interface with a single method.
/// </summary>
public interface IOne
{
    /// <summary>
    /// Performs a complex function on the input.
    /// </summary>
    /// <param name="input">An integer input.</param>
    /// <returns>An integer result.</returns>
    int ComplexFunction(int input);
}

/// <summary>
/// Provides static utility methods.
/// </summary>
public static class Two
{
    /// <summary>
    /// A static method that performs an operation using an input and an implementation of IOne.
    /// </summary>
    /// <param name="input">An integer input.</param>
    /// <param name="one">An implementation of the IOne interface.</param>
    /// <returns>An integer result.</returns>
    public static int F(int input, IOne one)
    {
        return one.ComplexFunction(input);
    }
}
