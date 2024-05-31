pipeline {
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
            
                bat 'C:\\Users\\y_dja\\.nuget\\packages\\nunit.consolerunner\\3.17.0\\tools\\nunit3-console.exe "C:\\Users\\y_dja\\source\\repos\\CumpusFranceProject\\CumpusFranceProject\\bin\\Debug\\CumpusFranceProject.dll" --result=C:\\Users\\y_dja\\source\\repos\\CumpusFranceProject\\TestResults\\TestResults.xml;format=nunit2    ' 
				// Utilisation de 'bat' pour exécuter des commandes Windows
               

            }
			
			
        }
    }
	 post {
        always {
            // Publier les résultats des tests NUnit
            junit 'C:\\Users\\y_dja\\source\\repos\\CumpusFranceProject\\TestResults\\TestResults.xml'
        }
    }
}
