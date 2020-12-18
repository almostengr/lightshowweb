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

Since LEDs are used for the light show, it is not high at all. To run the show for 5 weeks, 
with all the lights on would cost $38.90.  Given that all the lights are not all the entire time and
the equipment is not running at max capacity (which hardly ever happens), the actual cost is less than this.

See [Do The Math](#do-the-math) for the breakout and how this cost was derived.

### Do The Math

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

I did have some items already on hand from existing projects that I was able
to use for this project. For those items, I used the current cost for those items.

This doesn't include the wood, nails, or paint that I used to build the control box
or the AC lights that I already had on hand.

* 24 fuse holders = $7.50
* 30 fuses (rated 2 Amps) = $17.97
* 2 8-channel solid state relays = $9.33
* 25 SPT-2 male plugs = $23.99
* 25 SPT-2 female plugs = $23.99
* FM transmitter = $12.49
* Raspberry Pi 3 = $40.00
* Assorted breadboard wires = $7.49
* 3.5mm audio cable = $5.99
* 12 outlets (used) = $6.00
* 6 outlet boxes and outlet faceplates = $12.00
* 14 gauge wire (25 ft) = $12.73
* 16 gauge wire (25 ft) = $8.98
* 2 SPT-2 18 gauge 150 ft spools = 94.13
* 1000 additional AC lights = $50.00

Total $332.59

All prices are listed in USD.