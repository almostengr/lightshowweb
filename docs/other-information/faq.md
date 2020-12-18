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

With all lights turned on (current count is 2130 LEDs), it pulls 130 Watts.
The show controller and components can pull a maximum of 480 Watts.
Thus the show in total can use 610 (480 + 130) Watts maximum.

The lights run for 33.5 hours per week (Sunday through Thursday, 4.5 hours; Friday and Saturday, 5.5 hours).
The show runs for 5 weeks during the Christmas season.
The controller runs 168 hours per week (24 hours per day).

Electric companies measure the amount of electricity that you use in kilowatt-hours.
To convert W (Watts) to kWh (kilowatt-hours), you have to compute the lights and controller separately
since they are on for different durations.

```shell
E(kWh lights) = P(W) × t(hr) / 1000 = 130 Watts * 33.5 hours / 1000 = 4.355 kWh

E(kWh controller) = P(W) × t(hr) / 1000 = 480 Watts * 168 hours / 1000 = 80.64 kWh
```

That means the total kWh used is

```shell
80.64 + 4.355 = 84.995 kWh
```

The rate for electricity during the winter months (Oct-May) is $0.100511 per kWh.

```shell
Cost for lights = 0.100511 * 4.355 kWh = 0.44

Cost for controller = 0.100511 * 80.64 kWh = 8.11
```

That means the maximum total cost of the show for the entire
Christmas season would be $8.55 or 24 cents per day.

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