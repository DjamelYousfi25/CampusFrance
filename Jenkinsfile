﻿pipeline {
    agent any
 
    stages {
        stage('Checkout') {
            steps {
          
                git credentialsId: 'TokenCam', url: 'https://github.com/DjamelYousfi25/CampusFrance.git', branch: 'main'
            }
        }
        stage('Clean solution ') {
            steps {
            
                bat '"C:\\Program Files\\dotnet\\dotnet.exe" clean C:\\Users\\y_dja\\source\\repos\\CumpusFranceProject\\CumpusFranceProject -c:Debug'
           
            }
        }
        stage('Build') {
            steps {
            
                bat '"C:\\Program Files\\dotnet\\dotnet.exe" build C:\\Users\\y_dja\\source\\repos\\CumpusFranceProject\\CumpusFranceProject' // Utilisation de 'bat' pour exécuter des commandes Windows
               

            }
        }
         stage('Run') {
            steps {
            
                bat '"C:\\Program Files\\dotnet\\dotnet.exe" test C:\\Users\\y_dja\\source\\repos\\CumpusFranceProject\\CumpusFranceProject\\bin\\Debug\\CumpusFranceProject.dll -c:Debug' // Utilisation de 'bat' pour exécuter des commandes Windows
               

            }
        }
    }
}
