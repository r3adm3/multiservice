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

    stage('addService test') {
      steps {
        sh 'dotnet test addService.Tests/'
      }
    }

    stage('addService publish'){
      steps{
        sh 'dotnet publish addService/'
        }
    }

  }
}