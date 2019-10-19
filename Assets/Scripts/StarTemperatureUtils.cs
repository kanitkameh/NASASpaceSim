using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarTemperatureUtils : MonoBehaviour
{
    private const double h = 6.63e-34; //Planck's constant
    private const double c = 3e8; //speed of light
    private const double k = 1.38e-23;
    private const double wienDisplacement = 2.897771955e-3;

    // Wien's displacement law
    // Wavelength is measured in meters
    public double getMostIntensiveWavelengthFromTemperature(double Kelvin){
        return wienDisplacement/Kelvin;
    }
    public Color getColorFromStarTemperature(double Kelvin){
        int waveInNanometers = (int)(getMostIntensiveWavelengthFromTemperature(Kelvin)*Math.Pow(10,9));
        return new WaveToRGB().waveToRGB(waveInNanometers);
    }
    // Planck's law
    // Don't use it because it doesn't compute the values 100% correctly
    // wavelength is measured in meters, temperature in Kelvins
    double getWaveIntensity(double wavelength,double temperature){
        return ((2d*h*Math.Pow(c,2d))/Math.Pow(wavelength,5d)) * (1d/(Math.Pow(Math.E,h*c/wavelength*k*temperature)-1));
    }
}
