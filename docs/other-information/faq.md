---
title: FAQ
---

# FAQ (Frequently Asked Questions)

## How do you keep the lights from shorting or tripping breakers during wet weather?

Each connection that is on the ground is wrapped in electrical tape. That prevents water from
reaching the connections, which would result in an electrical short, thus tripping the breaker and
shutting down the show.

Outlets and plugs that are not on the ground, are pointed downwards so that water cannot enter the
socket, which would result in a short.

## How much does it cost to run the light show? Your electric bill must be high!

### Short Answer

Since LEDs are used for the light show, it is not high at all. To run the show for 5 weeks, 
with all the lights on would cost a maximum of $38.90.  Given that all the lights are not all the entire time and
the equipment is not running at max capacity (which hardly ever happens), the actual cost is less than this.

See [Do The Math](#long-answer-do-the-math) for the breakout and how this cost was derived.

### Long Answer - Do The Math

With all lights turned on (2130 LEDs were used for the 2020 Light Show), it pulls 130 Watts.
The show controller and components can pull a maximum of 305 Watts.
Thus the show in total can use 435 (130 + 305) Watts maximum.

The lights run for 33.5 hours per week (Sunday through Thursday, 4.5 hours; Friday and Saturday, 5.5 hours).
The show runs for 5 weeks during the Christmas season.
The controller runs 168 hours per week (24 hours per day).

Electric companies measure the amount of electricity that you use in kilowatt-hours.
To convert W (Watts) to kWh (kilowatt-hours), you have to compute the lights and controller separately
since they are on for different durations.

```shell
E(kWh lights) = P(W) × t(hr) / 1000 = 130 Watts * 33.5 hours / 1000 = 4.355 kWh

E(kWh controller) = P(W) × t(hr) / 1000 = 435 Watts * 168 hours / 1000 = 73.08 kWh
```

The rate for electricity during the winter months (Oct-May) is $0.100511 per kWh.

```shell
Cost for lights = 0.100511 * 4.355 kWh = 0.44

Cost for controller = 0.100511 * 73.08 kWh = 7.34
```

That means the maximum total cost of the show per week is 
Christmas season would be $7.78 or $38.90 for the entire season.

Now given that the light show does not have all of the lights on at any given point during the show and
the controller is not running at maximum capacity all of the time, the
actual cost is less than the above mentioned amount.

## What have you done in previous years?

Use the navigation on the left to see the information about the displays from previous years.

## You built a control box for your show. How much did that cost?

A total of $332.59.
I did have some items already on hand from existing projects that I was able
to use for this project. For those items, I used the current cost for those items.
This doesn't include the wood, nails, or paint that I used to build the control box
or the AC lights that I already had on hand.

## What are the parts that I need to build my own control box?

This is the list of the electrical related components. The full list of components will vary depending
upon how to you choose to design your control box.

* Fuse holders (x24) = $7.50
* Fuses (rated 2 Amps) (x30)= $17.97
* 8-channel solid state relays (x2) = $9.33
* SPT-2 male plugs (x25) = $23.99
* SPT-2 female plugs (x25) = $23.99
* FM transmitter = $12.49
* Raspberry Pi 3 = $40.00
* Assorted breadboard wires (x40) = $7.49
* 3.5mm audio cable = $5.99
* Outlets (used) (x12) = $6.00
* Outlet boxes and outlet faceplates (x6) = $12.00
* 14 gauge wire (25 ft) = $12.73
* 16 gauge wire (25 ft) = $8.98
* SPT-2 18 gauge 150 ft spools (x2) = $94.13
* Additional AC lights (10 strands, 100 lights each) = $50.00

Total = $332.59 

*All prices are listed in USD. Does not include taxes or shipping fees.*

## What kind of hardware do you use?

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

## What kind of software do you use?

### Xlights

The music and light sequences are timed together using Xlights. This software is open source
and runs on most operating systems, including Windows, Linux, and Mac.

### Falcon Pi Player (FPP)

Once the sequences have been created in Xlights, those files are copied over to FPP. From there, the
show data files, music files, and scheduling are all connected within this software.

### Kdenlive

Kdenlive is a video editing tool. It can also be used to modify audio files. The show intro audio file was
modified with Kdenlive to have the voice over and background music on the same track.