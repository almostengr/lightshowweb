# 2020 Christmas Light Show

## Show Times and Dates

Show will run nightly from November 27, 2020 until January 2, 2021.

* Sunday-Thursday, 5:30 PM (17:30) until 10:00 PM (22:00)
* Friday and Saturday, 5:30 PM (17:30) until 11:00 PM (23:00)

### Rain Delays

During times of heavy rain, or in the worse case snow, the light show may be stopped to reduce the
chance of electrical shorts occurring. If the show is cancelled, it is asked that you revisit
another evening after the rain has cleared.

## Music

### Listen From Your Car

To listen to the light show, tune your radio to 90.3 FM.
It is asked that you keep your radio volume down to not disturb the neighbors and 
passengers remain in your vehicle to observe social distancing guidelines and for your safety.

### Show Playlist

The songs below are synchronized to the lights and play during [show times](#show-times-and-dates) on loop.

* Show Introduction (01:49)
* Boyz II Men Countdown (00:10)
* 20th Century Fox Theme (00:20)
* Christmas Time Is Party Time - Luke (03:21)
* Christmas Eve/Sarajevo - Trans-Siberian Orchestra (03:24)
* What You Want For Christmas - Quad City DJs and K-nock (04:35)
* Silent Night - The Temptations (06:16)

### Offline Playlist

The songs below play on loop during non-showtime hours. Lights do not synchronize to music during
non-show hours.

* Christmas In Hollis - Run DMC (04:02)
* Christmas Song - Alvin and the Chimpmunks (02:21)
* Christmas Time Is Party Time - Luke (03:21)
* Knockin Boots On Christmas - H-Town (04:57)
* What You Want For Christmas - Quad City DJs and K-nock (04:35)
* O Holy Night - Mariah Carey (04:27)
* O Come All Ye Faithful - Luther Vandross (04:19)
* Christmas Eve/Sarajevo - Trans-Siberian Orchestra (03:24)
* Silent Night - The Temptations (06:16)
* All I Want For Christmas Is You - Mariah Carey (03:55)

## Hardware

### Raspbery Pi

The Falcon Pi Player is installed in the Raspberry Pi. The Rasberry Pi controls the relays, which in turn
controls all of the lights. The Pi controls each of the 24 channels of relays via the GPIO pins on the
Raspberry Pi.

### Christmas Lights

All of the lights are LED. Only two colors are used for the light show, white and red.

### Relays

All of the relays are Solid State Relays (SSR). SSRs were used because they have no mechanical or moving
parts and having greater reliability for being switched on and off frequently. 

Mechanical relays heat up from switching on an off. When done repeatedly, like during a song, the relay can
actually over heat and self-destruct.

### FM Transmission

Music is transmitted over radio via a low-power FM transmitter. Music goes into the transmitter directly from
the Raspberry Pi and broadcasted on an open frequency. Radio Locator in
[Other Resources](#other-resources) was used to locate the best frequency.

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

## Pictures

Coming soon. 

## Videos

Coming soon.

## Resources

Below are links to other websites and reference documentation that was used to build this light show.

### Light Show Websites

* <a href="http://www.lightinguppaxton.com/" target="_blank">Lighting Up Paxton</a>
* <a href="https://www.lightstoabeat.com" target="_blank">Lights To A Beat</a>
* <a href="https://sites.google.com/site/listentoourlights/home" target="_blank">Listen To Our Lights</a>
* <a href="https://www.zeemaps.com/map?group=3242152">Map of Light Displays</a>
* <a href="http://www.mosslights.com" target="_blank">Moss Lights</a>
* <a href="http://www.thechristmaslightshow.com/" target="_blank">The Christmas Light Show</a>
* <a href="https://tzchristmas.com" target="_blank">Thyno Zgouvas' Christmas Wonderland</a>

### Resources and Other Information

* <a href="http://www.falconchristmas.com" target="_blank">Falcon Christmas</a>
* <a href="https://radio-locator.com/cgi-bin/vacant" target="_blank">Radio Locator, find vacant radio channels</a>
* <a href="https://ttstool.com" target="_blank">TTS Tool, for text to speech recordings</a>

## FAQ (Frequently Asked Questions)

### How do you keep the lights from shorting or tripping breakers during wet weather?

Each connection that is on the ground is wrapped in electrical tape. That prevents water from
reaching the connections, which would result in an electrical short, thus tripping the breaker and
shutting down the show.

### How much does the show raise your power bill?

Not sure. This is the first year doing an animated display, so there's no comparison from previous years. 
An update will be provided on this at a later time.

### What have you done in previous years?

Use the navigation on the left to see the information about the displays from previous years.
