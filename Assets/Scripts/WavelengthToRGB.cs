using UnityEngine;

namespace Wavelength {
    public class WaveToRGB {
    //Wavelength is in nanometers
        static public Color waveToRGB(int wavelength) {
            float attenuation;
            float R, G, B;
            Debug.Log(wavelength);
            if (wavelength >= 380f & wavelength <= 440f) {
                attenuation = 0.3f + 0.7f * (wavelength - 380f) / (440f - 380f);
                R = ((-(wavelength - 440f) / (440f - 380f)) * attenuation);
                G = 0f;
                B = (1f * attenuation);
                Debug.Log(R + " " + G + " " + B);
                
            }
            else if (wavelength >= 440f & wavelength <= 490f) {
                R = 0f;
                G = ((wavelength - 440f) / (490f - 440f));
                B = 1f;
                Debug.Log(R + " " + G + " " + B);
            }
            else if (wavelength >= 490f & wavelength <= 510f) {
                R = 0f;
                G = 1f;
                B = (-(wavelength - 510f) / (510f - 490f));
            }
            else if (wavelength >= 510f & wavelength <= 580f) {
                R = ((wavelength - 510f) / (580f - 510f));
                G = 1f;
                B = 0f;
            }
            else if (wavelength >= 580f & wavelength <= 645) {
                R = 1f;
                G = (-(wavelength - 645) / (645 - 580f));
                B = 0f;
            }
            else if (wavelength >= 645 & wavelength <= 750f) {
                attenuation = 0.3f + 0.7f * (750f - wavelength) / (750f - 645);
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
}