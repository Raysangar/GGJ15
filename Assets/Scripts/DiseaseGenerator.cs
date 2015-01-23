using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    static class DiseaseGenerator
    {
        public static void setDiseases(GameObject patient, int level)
        {
            Patient patientComponent = patient.GetComponent<Patient>();
            ArrayList activeDiseases = new ArrayList();
            Disease[] diseases = patient.GetComponentsInChildren<Disease>();
            foreach (Disease disease in diseases)
            {
                disease.gameObject.SetActive(true);
                activeDiseases.Add(disease);
            }
            patientComponent.setDiseases(activeDiseases);
        }
    }
}
