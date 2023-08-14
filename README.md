# Personal Site

This is the C# project that powers my personal site.

Contained within is an ASP.NET server mapping and serving Razor pages, as well as the static
files for styling and favicons.

## Running as a Standalone

You can simply clone the repository and run `dotnet run -c Release --project PersonalSite`.

## Running as a Service

Service unit files are provided for systemd in the `PersonalSite.Services` directory attached
to the solution. You can install them by copying either the `PersonalSite.Release.service` or
`PersonalSite.Debug.service` file to `/etc/systemd/system/PersonalSite.service`, editing the
values to match your environment, and running `systemctl enable PersonalSite.service`. This
will automatically build and run the server, as well as restart on failure.