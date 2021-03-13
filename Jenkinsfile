pipeline {
  agent any
  stages {
    stage('Env Checks') {
      steps {
        sh '''
echo Test Script
pwd
ls -R'''
      }
    }

    stage('multiservice test') {
      steps {
        sh 'dotnet test addService.Tests/'
      }
    }

    stage('multiservice publish')
      steps{
        sh '''
cd frontend
dotnet publish
        '''
      }

  }
}