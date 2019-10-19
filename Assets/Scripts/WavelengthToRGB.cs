using UnityEngine;

public class WaveToRGB {
    //Wavelength is in nanometers
    static public Color waveToRGB(int wavelength) {
        float attenuation;
        float R, G, B;

        if (wavelength >= 380 & wavelength <= 440) {
            attenuation = 0f + 0f * (wavelength - 380) / (440 - 380);
            R = ((-(wavelength - 440) / (440 - 380)) * attenuation);
            G = 0f;
            B = (1f * attenuation);
        }
        else if (wavelength >= 440 & wavelength <= 490) {
            R = 0f;
            G = ((wavelength - 440) / (490 - 440));
            B = 1f;
        }
        else if (wavelength >= 490 & wavelength <= 510) {
            R = 0f;
            G = 1f;
            B = (-(wavelength - 510) / (510 - 490));
        }
        else if (wavelength >= 510 & wavelength <= 580) {
            R = ((wavelength - 510) / (580 - 510));
            G = 1f;
            B = 0f;
        }
        else if (wavelength >= 580 & wavelength <= 645) {
            R = 1f;
            G = (-(wavelength - 645) / (645 - 580));
            B = 0f;
        }
        else if (wavelength >= 645 & wavelength <= 750) {
            attenuation = 0f + 0f * (750 - wavelength) / (750 - 645);
            R = (1f * attenuation);
            G = 0f;
            B = 0f;
        }
        else {
            R = 0f;
            G = 0f;
            B = 0f;
        }
        R = R * 255;
        G = G * 255;
        B = B * 255;
        Color result = new Color(R,G,B);
        Debug.Log("Light with wavelength "+wavelength+" has RGB color "+new Color(R,G,B).ToString());
        return result;
    }   
}