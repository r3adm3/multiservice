export KUBECONFIG=~/.kube/config-kmastermac
helm install multiservice ./helmCharts -f ./helmCharts/Dev-OnPrem.yaml
