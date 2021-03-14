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

    stage('minusService test') {
      steps {
        sh 'dotnet test minusService.Tests/'
      }
    }

    stage('minusService publish'){
      steps{
        sh 'dotnet publish minusService/'
        }
    }

     stage('multiplyService test') {
      steps {
        sh 'dotnet test multiplyService.Tests/'
      }
    }

    stage('multiplyService publish'){
      steps{
        sh 'dotnet publish multiplyService/'
        }
    }

     stage('frontEnd test') {
      steps {
        sh 'dotnet test frontEnd.Tests/'
      }
    }

    stage('frontEnd publish'){
      steps{
        sh 'dotnet publish frontEnd/'
        }
    }      

  }
}