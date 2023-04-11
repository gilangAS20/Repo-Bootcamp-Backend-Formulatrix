using System;

class MyClass : IDisposable
{
    // Flag to indicate whether the object has been disposed
    private bool disposed = false;

    // Public method to release resources held by the object
    public void Dispose()
    {
        // Call the protected virtual method with disposing=true to release managed resources
        Dispose(true);

        // Suppress finalization to prevent the finalizer from being called
        GC.SuppressFinalize(this);
    }

    // Protected virtual method to release resources held by the object
    protected virtual void Dispose(bool disposing)
    {
        // Check if the object has already been disposed
        if (!disposed)
        {
            if (disposing)
            {
                // Release any managed resources here
            }

            // Release any unmanaged resources here

            // Set the disposed flag to true
            disposed = true;
        }
    }

    // Finalizer to release unmanaged resources
    ~MyClass()
    {
        // Call the protected virtual method with disposing=false to release unmanaged resources
        Dispose(false);
    }
}
