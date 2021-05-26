# NRuuviTag

A collection of .NET libraries to simplify interacting with RuuviTag IoT sensors from [Ruuvi](https://www.ruuvi.com/).

The repository contains a [core library](/src/NRuuviTag.Core) that defines common types, and a [listener implementation](/src/NRuuviTag.Listener.Windows) that uses the Windows 10 SDK to observe the Bluetooth LE advertisements emitted by RuuviTag devices. Samples received from RuuviTags can be automatically [published to an MQTT broker](#publishing-samples-to-mqtt).

The `nruuvitag` [command-line tool](#command-line-application) can be used to as a turnkey solution to start receiving and publishing RuuviTag sensor data to an MQTT broker.


# Example Usage

> See the [samples](/samples) folder for more details examples of usage.

Usage is very straightforward. For example, to listen via the Windows 10 SDK using the [NRuuviTag.Listener.Windows](https://www.nuget.org/packages/NRuuviTag.Listener.Windows) NuGet package ([source](/src/NRuuviTag.Listener.Windows)):

```csharp
var client = new WindowsSdkListener();

await foreach (var sample in client.ListenAsync(cancellationToken)) {
    // sample is a RuuviTagSample object.
}
```

To only observe specific RuuviTag devices using the Windows SDK using MAC address filtering:

```csharp
var client = new WindowsSdkListener();

bool CanProcessMessage(string macAddress) {
    return string.Equals(macAddress, "AB:CD:EF:01:23:45");
}

await foreach (var sample in client.ListenAsync(CanProcessMessage, cancellationToken)) {
    // sample is a RuuviTagSample object.
}
```


# Publishing Samples to MQTT

The [NRuuviTag.Mqtt.Agent](https://www.nuget.org/packages/NRuuviTag.Mqtt.Agent) NuGet package ([source](/src/NRuuviTag.Mqtt.Agent)) can be used to observe RuuviTag broadcasts and forward the samples to an MQTT broker.


# Command-Line Application

`nruuvitag` is a command-line tool for [Windows](/src/NRuuviTag.Cli.Windows) that can scan for nearby RuuviTags, and publish device readings to the console or to an MQTT broker.

Examples:

```
# Scan for nearby devices

nruuvitag devices scan
```

```
# Write sensor readings from all nearby devices to the console

nruuvitag publish console
```

```
# Add a device to the known devices list

nruuvitag devices add "AB:CD:EF:01:23:45" --id "bedroom-1" --name "Master Bedroom"
```

```
# Publish readings from known devices to an MQTT broker

nruuvitag publish mqtt my-mqtt-service.local:1883 --client-id "MY_CLIENT_ID" --topic "{clientId}/my-ruuvi-tags/{deviceId}" --known-devices
```


# Building the Solution

The repository uses [Cake](https://cakebuild.net/) for cross-platform build automation. The build script allows for metadata such as a build counter to be specified when called by a continuous integration system such as TeamCity.

A build can be run from the command line using the [build.ps1](/build.ps1) PowerShell script. For documentation about the available build script parameters, see [build.cake](/build.cake).
