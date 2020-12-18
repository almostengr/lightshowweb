# The Technology

## Hardware

### Raspbery Pi

The Falcon Pi Player is installed in the Raspberry Pi. The Rasberry Pi controls the relays, which in turn
controls all of the lights. The Pi controls each of the 24 channels of relays via the GPIO pins on the
Raspberry Pi.

### Christmas Lights

All of the lights are LED. Only two colors are used for the light show, white and red.

### Solid State Relays

All of the relays are Solid State Relays (SSR). SSRs were used because they have no mechanical or moving
parts and having greater reliability for being switched on and off frequently. 

Mechanical relays heat up from switching on an off. When done repeatedly, like during a song, the relay can
actually over heat, self-destruct, or weld itself closed.

### FM Radio Transmission

Music is transmitted over radio via a low-power FM transmitter. Music goes into the transmitter directly from
the Raspberry Pi and broadcasted on an open frequency. Radio Locator in the
[Resources](/other-information/resources) was used to locate the best frequency.

## Software

### Xlights

The music and light sequences are timed together using Xlights. This software is open source
and runs on most operating systems, including Windows, Linux, and Mac.

### Falcon Pi Player (FPP)

Once the sequences have been created in Xlights, those files are copied over to FPP. From there, the
show data files, music files, and scheduling are all connected within this software.

### Kdenlive

Kdenlive is a video editing tool. It can also be used to modify audio files. The show intro audio file was
modified with Kdenlive to have the voice over and background music on the same track.