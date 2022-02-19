export KUBECONFIG=~/.kube/config-dockerdesktop
helm install multiservice ./helmCharts -f ./helmCharts/Dev.yaml
