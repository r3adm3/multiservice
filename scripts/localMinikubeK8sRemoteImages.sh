export KUBECONFIG=~/.kube/config-minikube
echo using $KUBECONFIG
helm install multiservice ./helmCharts -f ./helmCharts/Dev-OnPrem.yaml
